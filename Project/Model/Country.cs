using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Geography
{
    public class Country
    {
        #region Attribute
        private string _name;
        private Color _backColor;
        private Color _borderColor;
        private string _coordonates;
        private string _id;
        private string _code;
        private string _trigram;
        private int _population;
        private double _latitude;
        private double _longitude;
        private string _capitale;
        private string _gdp;
        private string _phonePrefix;
        private int _area;
        private string _continent;
        private int _customValue;
        #endregion

        #region Properties
        public int CustomValue
        {
            get { return _customValue; }
            set { _customValue = value; }
        }
        public string Continent
        {
            get { return _continent; }
            set { _continent = value; }
        }
        public int Area
        {
            get { return _area; }
            set { _area = value; }
        }
        public string PhonePrefix
        {
            get { return _phonePrefix; }
            set { _phonePrefix = value; }
        }
        public string GDP
        {
            get { return _gdp; }
            set { _gdp = value; }
        }
        public string Capitale
        {
            get { return _capitale; }
            set { _capitale = value; }
        }
        public double Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }
        public double Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }
        public int Population
        {
            get { return _population; }
            set { _population = value; }
        }
        public string Trigram
        {
            get { return _trigram; }
            set { _trigram = value; }
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Coordonates
        {
            get { return _coordonates; }
            set { _coordonates = value; }
        }
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }
        public Color BackColor
        {
            get { return _backColor; }
            set { _backColor = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region Constructor
        public Country()
        {

        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
