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
            comboBox2.Items.Clear();
            foreach (Country country in _worldMap.Countries)
            {
                comboBox1.Items.Add(country.Name);
                comboBox2.Items.Add(country.Name);
            }
        }
        #endregion

        #region Event
        #endregion
    }
}
