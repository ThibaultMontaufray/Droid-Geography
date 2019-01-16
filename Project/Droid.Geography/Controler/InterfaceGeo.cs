using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Utilities;

namespace Droid.Geography
{
    public class InterfaceGeo : GPInterface
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public InterfaceGeo()
        {
            GetLocationProperty();
        }
        #endregion

        #region Methods public
        public override void GoAction(string action)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods private
        private void GetLocationProperty()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            // Do not suppress prompt, and wait 1000 milliseconds to start.
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;

            if (coord.IsUnknown != true)
            {
                Console.WriteLine("Lat: {0}, Long: {1}",
                    coord.Latitude,
                    coord.Longitude);
            }
            else
            {
                Console.WriteLine("Unknown latitude and longitude.");
            }

            CLocation myLocation = new CLocation();
            myLocation.GetLocationEvent();
            Console.WriteLine("Enter any key to quit.");
            Console.ReadLine();
        }
        #endregion

        #region Event
        #endregion
    }
    class CLocation
    {
        GeoCoordinateWatcher watcher;

        public void GetLocationEvent()
        {
            this.watcher = new GeoCoordinateWatcher();
            this.watcher.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(watcher_PositionChanged);
            bool started = this.watcher.TryStart(false, TimeSpan.FromMilliseconds(2000));
            if (!started)
            {
                Console.WriteLine("GeoCoordinateWatcher timed out on start.");
            }
        }

        void watcher_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            PrintPosition(e.Position.Location.Latitude, e.Position.Location.Longitude);
        }

        void PrintPosition(double Latitude, double Longitude)
        {
            Console.WriteLine("Latitude: {0}, Longitude {1}", Latitude, Longitude);
        }
    }
}
