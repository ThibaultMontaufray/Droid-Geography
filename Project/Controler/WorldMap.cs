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
        #region Enum
        public enum PresentationMode
        {
            POPULATION,
            AREA,
            COUNTRY,
            CUSTOM
        }
        #endregion

        #region Attribute
        private string _htmlHeader;
        private string _htmlFooter;

        private List<Country> _countries;
        private Country _currentCountry;
        private int _zoom;
        private bool _runAnimation;
        private PresentationMode _mode;
        private string _workingDirectory;
        #endregion

        #region Properties
        public string WorkingDirectory
        {
            get { return _workingDirectory; }
            set { _workingDirectory = value; }
        }
        public PresentationMode Mode
        {
            get { return _mode; }
            set { _mode = value; }
        }
        public List<Country> Countries
        {
            get { return _countries; }
            set { _countries = value; }
        }
        public string WorldPage
        {
            get { return BuildHtmlPage(); }
        }
        public bool RunAnimation
        {
            get { return _runAnimation; }
            set { _runAnimation = value; }
        }
        public int Zoom
        {
            get { return _zoom; }
            set { _zoom = value; }
        }
        public Country CurrentCountry
        {
            get { return _currentCountry; }
            set { _currentCountry = value; }
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
            _zoom = 6;
            _runAnimation = true;
            _mode = PresentationMode.POPULATION;

            InitResourcesFolder();
            InitHtmlConst();
            LoadFileCsv();
            LoadFileHtml();
        }
        private void InitResourcesFolder()
        {
            string currentDir;
            _workingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-Geography";
            if (!Directory.Exists(_workingDirectory)) { Directory.CreateDirectory(_workingDirectory); }
            if (!Directory.Exists(Path.Combine(_workingDirectory, "WorldMap")))
            {
                Directory.CreateDirectory(Path.Combine(_workingDirectory, "WorldMap"));
                foreach (var file in Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, "Resources", "WorldMapResources")))
                {
                    File.Copy(file, Path.Combine(_workingDirectory, "WorldMap", Path.GetFileName(file)));
                }

                foreach (var dir in Directory.GetDirectories(Path.Combine(Environment.CurrentDirectory, "Resources", "WorldMapResources")))
                {
                    currentDir =dir.Split('\\')[dir.Split('\\').Length-1];
                    Directory.CreateDirectory(Path.Combine(_workingDirectory, "WorldMap", currentDir));

                    foreach (var file in Directory.GetFiles(dir))
                    {
                        File.Copy(file, Path.Combine(_workingDirectory, "WorldMap", currentDir, Path.GetFileName(file)));
                    }
                }
            }
        }
        private void InitHtmlConst()
        {
            _htmlHeader = @"<!DOCTYPE html>
            <html>
            <head>
                <meta http-equiv='X-UA-Compatible' content='IE=11' /> 
                <title>jVectorMap demo</title>
                <link rel = 'stylesheet' media= 'all' href= '#####/jquery-jvectormap.css' />
                <script src= '#####/src/jquery-1.8.2.js' ></script>
                <script src= '#####/jquery-jvectormap.js' ></script>
                <script src= '#####/lib/jquery-mousewheel.js' ></script>
                <script src= '#####/src/jvectormap.js' ></script>
                <script src= '#####/src/abstract-element.js' ></script>
                <script src= '#####/src/abstract-canvas-element.js' ></script>
                <script src= '#####/src/abstract-shape-element.js' ></script>
                <script src= '#####/src/svg-element.js' ></script>
                <script src= '#####/src/svg-group-element.js' ></script>
                <script src= '#####/src/svg-canvas-element.js' ></script>
                <script src= '#####/src/svg-shape-element.js' ></script>
                <script src= '#####/src/svg-path-element.js' ></script>
                <script src= '#####/src/svg-circle-element.js' ></script>
                <script src= '#####/src/svg-image-element.js' ></script>
                <script src= '#####/src/svg-text-element.js' ></script>
                <script src= '#####/src/vml-element.js' ></script>
                <script src= '#####/src/vml-group-element.js' ></script>
                <script src= '#####/src/vml-canvas-element.js' ></script>
                <script src= '#####/src/vml-shape-element.js' ></script>
                <script src= '#####/src/vml-path-element.js' ></script>
                <script src= '#####/src/vml-circle-element.js' ></script>
                <script src= '#####/src/vml-image-element.js' ></script>
                <script src= '#####/src/map-object.js' ></script>
                <script src= '#####/src/region.js' ></script>
                <script src= '#####/src/marker.js' ></script>
                <script src= '#####/src/vector-canvas.js' ></script>
                <script src= '#####/src/simple-scale.js' ></script>
                <script src= '#####/src/ordinal-scale.js' ></script>
                <script src= '#####/src/numeric-scale.js' ></script>
                <script src= '#####/src/color-scale.js' ></script>
                <script src= '#####/src/legend.js' ></script>
                <script src= '#####/src/data-series.js' ></script>
                <script src= '#####/src/proj.js' ></script>
                <script src= '#####/src/map.js' ></script>
                <script src= '#####/src/jquery-jvectormap-world-mill-en.js' ></script>
                <script >
                jQuery.noConflict();
                jQuery(function()
                    {
                        var $ = jQuery;
                        $('#map1').vectorMap({
                            map: 'world_mill_en',
                            panOnDrag: true,
                            focusOn:
                            {
                                [X],
                                [Y],
                                scale: [ZOOM],
                                animate: [ANIMATION]
                            },
                            series:
                            {
                                regions: [{
                                    scale: ['#C8EEFF', '#0071A4'],
                                    normalizeFunction: 'polynomial',
                                    values:
                                    {
                                        ";
            _htmlHeader = _htmlHeader.Replace("#####", _workingDirectory + "/WorldMap");

            _htmlFooter = @"}
                        }]
                    }
                  });
                })
                </script>
            </head>
            <body>
                <div id = 'map1' style='width: 600px; height: 400px'></div>
            </body>
            </html>;";
        }
        private string BuildHtmlPage()
        {
            string html = string.Empty;

            html += _htmlHeader;
            foreach (var c in _countries)
            {
                if (_currentCountry != null && _mode == PresentationMode.COUNTRY)
                {
                    if (_currentCountry.Equals(c))
                    {
                        html += string.Format("              '{0}': 1,", c.Code);
                    }
                    else
                    { 
                        html += string.Format("              '{0}': 0,", c.Code);
                    }
                    html = html.Replace("[X]", "lat: " + _currentCountry.Latitude.ToString().Replace(',', '.'));
                    html = html.Replace("[Y]", "lng: " + _currentCountry.Longitude.ToString().Replace(',', '.'));
                    _zoom = 4;
                }
                else
                {
                    switch (_mode)
                    {
                        case PresentationMode.AREA:
                            html += string.Format("              '{0}': {1},", c.Code, c.Area);
                            html = html.Replace("[X]", "x: 0.5");
                            html = html.Replace("[Y]", "y: 0.5");
                            break;
                        case PresentationMode.CUSTOM:
                            html += string.Format("              '{0}': {1},", c.Code, c.CustomValue);
                            html = html.Replace("[X]", "x: 0.5");
                            html = html.Replace("[Y]", "y: 0.5");
                            break;
                        case PresentationMode.POPULATION:
                    default:
                            html += string.Format("              '{0}': {1},", c.Code, c.Population);
                            html = html.Replace("[X]", "x: 0.5");
                            html = html.Replace("[Y]", "y: 0.5");
                            break;
                    }
                    _zoom = 1;
                }
            }
            html += _htmlFooter;
            html = html.Replace("\r\n", string.Empty);
            
            html = html.Replace("[ANIMATION]", _runAnimation.ToString().ToLower());
            html = html.Replace("[ZOOM]", _zoom.ToString());

            return html;
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
                    if (tab.Length == 10)
                    {
                        country = new Country()
                        {
                            Name = tab[0].Replace("\n", string.Empty),
                            Continent = tab[1],
                            Capitale = tab[2],
                            Latitude = !string.IsNullOrEmpty(tab[3]) ? double.Parse(string.Format("{0}{1},{2}",(tab[3].Contains("S") ? "-" : string.Empty), tab[3].Split('°')[0], tab[3].Split('°')[1].Split('\'')[0])) : 0,
                            Longitude = !string.IsNullOrEmpty(tab[4]) ? double.Parse(string.Format("{0}{1},{2}", (tab[4].Contains("W") ? "-" : string.Empty), tab[4].Split('°')[0], tab[4].Split('°')[1].Split('\'')[0])) : 0,
                            PhonePrefix = tab[5],
                            Code = !string.IsNullOrEmpty(tab[6]) ? tab[6].Split(' ')[0] : string.Empty,
                            Trigram = !string.IsNullOrEmpty(tab[6]) ? tab[6].Split(' ')[2] : string.Empty,
                            Population = !string.IsNullOrEmpty(tab[7]) ? int.Parse(Regex.Replace(tab[7], @"(?<=\d+)\s+(?=\d+)", "")) : 0,
                            Area = !string.IsNullOrEmpty(tab[8]) ? int.Parse(Regex.Replace(tab[8], @"(?<=\d+)\s+(?=\d+)", "")) : 0,
                            GDP = tab[9]
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

            //_worldPage = Properties.Resources.worldmap;

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
