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
            worldMapView1.CurrentWorldMap = _worldMap;
            worldMapView1.Width = 600;
            worldMapView1.Height = 400;

            comboBox1.Items.Clear();
            foreach (Country country in _worldMap.Countries)
            {
                comboBox1.Items.Add(country.Name);
            }
        }
        private void LoadCountry(string country)
        {
            _worldMap.CurrentCountry = _worldMap.Countries.Where(c => c.Name.Equals(country)).First();

            labelName.Text = "Name : " + _worldMap.CurrentCountry.Name;
            labelContinent.Text = "Continent : " + _worldMap.CurrentCountry.Continent;
            labelPopulation.Text = "Population : " + _worldMap.CurrentCountry.Population;
            labelTrigramme.Text = "Trigramme : " + _worldMap.CurrentCountry.Trigram;
            labelIso.Text = "Code : " + _worldMap.CurrentCountry.Code;
            labelArea.Text = "Superficie : " + _worldMap.CurrentCountry.Area;
            labelCapital.Text = "Capital : " + _worldMap.CurrentCountry.Capitale;
            labelCoordonate.Text = "Coordonate : " + _worldMap.CurrentCountry.Latitude + "N " + _worldMap.CurrentCountry.Longitude + "W";
            worldMapView1.UpdateMap();
        }
        #endregion

        #region Event
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonArea.Checked)
            {
                _worldMap.Mode = WorldMap.PresentationMode.AREA;
            }
            else if (radioButtonCustom.Checked)
            {
                _worldMap.Mode = WorldMap.PresentationMode.CUSTOM;
            }
            else if (radioButtonPop.Checked)
            {
                _worldMap.Mode = WorldMap.PresentationMode.POPULATION;
            }
            else if (radioButtonCountry.Checked)
            {
                _worldMap.Mode = WorldMap.PresentationMode.COUNTRY;
            }
            worldMapView1.UpdateMap();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCountry(comboBox1.SelectedItem.ToString());
            radioButtonCountry.Checked = true;
        }
        #endregion
    }
}
