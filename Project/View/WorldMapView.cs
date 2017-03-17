using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid_Geography
{
    public partial class WorldMapView : UserControl
    {
        #region Attribute
        private WorldMap _worldMap;
        private int _zoom;
        #endregion

        #region Properties
        public int Zoom
        {
            get { return _zoom; }
            set { _zoom = value; }
        }
        public WorldMap CurrentWorldMap
        {
            get { return _worldMap; }
            set { _worldMap = value; }
        }
        #endregion

        #region 
        public WorldMapView()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public void FocusCountry(string countryName)
        {
            var countries = _worldMap.Countries.Where(c => c.Name.Equals(countryName)).ToList();
            if (countries.Count > 0)
            {

            }
        }
        public void UpdateMap()
        {
            webBrowser.DocumentText = _worldMap.WorldPage;
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _worldMap = new WorldMap();
            webBrowser.DocumentText = _worldMap.WorldPage;
            webBrowser.ScriptErrorsSuppressed = true;
            //var v = webBrowser.Version;
        }
        #endregion

        #region Event
        #endregion
    }
}
