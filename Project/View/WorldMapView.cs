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
        private string _newHtmlPage;
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

        #region Constructor
        public WorldMapView()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public void UpdateMap()
        {
            _newHtmlPage = _worldMap.WorldPage;
            webBrowser.DocumentText = _worldMap.WorldPage;
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _newHtmlPage = string.Empty;
            _worldMap = new WorldMap();
            webBrowser.DocumentText = _worldMap.WorldPage;
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
            //var v = webBrowser.Version;
        }
        #endregion

        #region Event
        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (!string.IsNullOrEmpty(_newHtmlPage))
            {
                webBrowser.DocumentText = _newHtmlPage;
                _newHtmlPage = string.Empty;
            }
        }
        #endregion
    }
}
