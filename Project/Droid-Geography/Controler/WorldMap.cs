using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Droid_Geography
{
    public class WorldMap
    {
        #region Attribute
        private List<Country> _countries;
        private string _worldPage;
        #endregion

        #region Properties
        public List<Country> Countries
        {
            get { return _countries; }
            set { _countries = value; }
        }
        public string WorldPage
        {
            get { return _worldPage; }
            set { _worldPage = value; }
        }
        #endregion

        #region Constructor
        public WorldMap()
        {
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            _countries = new List<Country>();
            LoadFileCsv();
            LoadFileHtml();
        }

        internal object Where()
        {
            throw new NotImplementedException();
        }

        private void LoadFileCsv()
        {
            bool header = true;
            Country country;
            string[] tab;
            _countries = new List<Country>();

            string fileText = Properties.Resources.countries;

            foreach (string block in Regex.Split(fileText, "\r"))
            {
                if (!header)
                {
                    tab = Regex.Split(block, ";");
                    if (tab.Length == 9)
                    {
                        country = new Country()
                        {
                            Name = tab[0].Replace("\n", string.Empty),
                            Capitale = tab[1],
                            Latitude = !string.IsNullOrEmpty(tab[2]) ? double.Parse(string.Format("{0},{1}", tab[2].Split('°')[0], tab[2].Split('°')[1].Split('\'')[0])) : 0,
                            Longitude = !string.IsNullOrEmpty(tab[3]) ? double.Parse(string.Format("{0},{1}", tab[3].Split('°')[0], tab[3].Split('°')[1].Split('\'')[0])) : 0,
                            PhonePrefix = tab[4],
                            Code = !string.IsNullOrEmpty(tab[5]) ? tab[5].Split(' ')[0] : string.Empty,
                            Trigram = !string.IsNullOrEmpty(tab[5]) ? tab[5].Split(' ')[2] : string.Empty,
                            Population = !string.IsNullOrEmpty(tab[6]) ? int.Parse(Regex.Replace(tab[6], @"(?<=\d+)\s+(?=\d+)", "")) : 0,
                            Area = !string.IsNullOrEmpty(tab[7]) ? int.Parse(Regex.Replace(tab[7], @"(?<=\d+)\s+(?=\d+)", "")) : 0,
                            GDP = tab[8]
                        };
                        _countries.Add(country);
                    }
                }
                else
                {
                    header = false;
                }
            }
        }
        private void LoadFileHtml()
        {
            //bool header = true;
            //Country country;
            //string[] tab;
            //_countries = new List<Country>();

            _worldPage = Properties.Resources.worldmap;

            //foreach (string block in Regex.Split(_worldPage, "<path "))
            //{
            //    if (!header)
            //    {
            //        tab = Regex.Split(block, "\" ");
            //        if (tab.Length == 8)
            //        {
            //            country = new Country()
            //            {
            //                BackColor = Color.FromName(tab[0].Split('"')[1]),
            //                BorderColor = Color.FromName(tab[1].Split('"')[1]),
            //                Coordonates = tab[2].Split('"')[1],
            //                Id = tab[6].Split('"')[1],
            //                Name = tab[7].Split('>')[2].Split('<')[0]
            //            };
            //            _countries.Add(country);
            //        }
            //    }
            //    else
            //    {
            //        header = false;
            //    }
            //}
        }
        #endregion
    }
}
