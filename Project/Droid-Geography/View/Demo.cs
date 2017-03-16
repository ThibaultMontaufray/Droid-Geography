using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid_Geography
{
    public partial class Form1 : Form
    {
        #region Attribute
        private WorldMap _worldMap;
        #endregion

        #region Properties
        public WorldMap CurrentWorldMap
        {
            get { return _worldMap; }
            set { _worldMap = value; }
        }
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            _worldMap = new WorldMap();

            comboBox1.Items.Clear();
            foreach (Country country in _worldMap.Countries)
            {
                comboBox1.Items.Add(country.Name);
            }
        }
        private void LoadCountry(string country)
        {
            var contr = _worldMap.Countries.Where(c => c.Name.Equals(country)).First();
            labelName.Text = "Name : " + contr.Name;
            labelPopulation.Text = "Population : " + contr.Population;
            labelTrigramme.Text = "Trigramme : " + contr.Trigram;
            labelIso.Text = "Code : " + contr.Code;
            labelArea.Text = "Superficie : " + contr.Area;
            labelCapital.Text = "Capital : " + contr.Capitale;
            labelCoordonate.Text = "Coordonate : " + contr.Latitude + "N " + contr.Longitude + "W";
        }
        #endregion

        #region Event
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCountry(comboBox1.SelectedItem.ToString());
        }
        #endregion
    }
}
