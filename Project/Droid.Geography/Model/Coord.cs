using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Geography.Model
{
    public class Coord
    {
        #region Enum
        public enum Layout
        {
            ODDR,
            EVENR,
            ODDQ,
            EVENQ
        }
        #endregion

        #region Attribute
        public int X;
        public int Y;
        public int Z;

        public int Q; // Column
        public int R; // Row

        public Layout LayoutActive;
        #endregion

        #region Constructor
        public Coord()
        {
            LayoutActive = Layout.ODDR;
        }
        #endregion

        #region Mehtods public
        public static int CubeDistance(Coord a, Coord b)
        {
            return (Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y) + Math.Abs(a.Z - b.Z)) / 2;
        }
        public static int AxialDistance(Coord a, Coord b)
        {
            Coord ac = HexToCube(a);
            Coord bc = HexToCube(b);
            return CubeDistance(ac, bc);
        }
        #endregion

        #region Methods private
        private static Coord CubeToHex(Coord h)
        {
            var q = h.X;
            var r = h.Z;
            return Hex(q, r, h.LayoutActive);
        }
        private static Coord HexToCube(Coord h)
        {
            var x = h.Q;
            var z = h.R;
            var y = -x - z;
            return Cube(x, y, z, h.LayoutActive);
        }
        private static Coord Hex(int q, int r, Layout layout)
        {
            Coord c = new Coord() { Q = q, R = r, LayoutActive = layout };
            switch (layout)
            {
                case Layout.ODDR:
                    return OddRToCube(c);
                case Layout.EVENR:
                    return EvenRToCube(c);
                case Layout.ODDQ:
                    return OddQToCube(c);
                case Layout.EVENQ:
                    return EvenQToCube(c);
                default:
                    return null;
            }
        }
        private static Coord Cube(int x, int y, int z, Layout layout)
        {
            Coord c = new Coord() { X = x, Y = y, Z = z, LayoutActive = layout };
            switch (layout)
            {
                case Layout.ODDR:
                    return CubeToOddR(c);
                case Layout.EVENR:
                    return CubeToEvenR(c);
                case Layout.ODDQ:
                    return CubeToOddQ(c);
                case Layout.EVENQ:
                    return CubeToEvenQ(c);
                default:
                    return null;
            }
        }
        private static Coord CubeToEvenQ(Coord c)
        {
            c.Q = c.X;
            c.R = c.Z + (c.X + (c.X & 1)) / 2;
            return c;
        }
        private static Coord CubeToEvenR(Coord c)
        {
            c.Q = c.X + (c.Z + (c.Z & 1)) / 2;
            c.R = c.Z;
            return c;
        }
        private static Coord CubeToOddQ(Coord c)
        {
            c.Q = c.X;
            c.R = c.Z + (c.X - (c.X & 1)) / 2;
            return c;
        }
        private static Coord CubeToOddR(Coord c)
        {
            c.Q = c.X + (c.Z - (c.Z & 1)) / 2;
            c.R = c.Z;
            return c;
        }
        private static Coord EvenQToCube(Coord c)
        {
            c.X = c.Q;
            c.Z = c.R - (c.Q + (c.Q & 1)) / 2;
            c.Y = -c.X - c.Z;
            return c;
        }
        private static Coord EvenRToCube(Coord c)
        {
            c.X = c.Q - (c.R + (c.R & 1)) / 2;
            c.Z = c.R;
            c.Y = -c.X - c.Z;
            return c;
        }
        private static Coord OddQToCube(Coord c)
        {
            c.X = c.Q;
            c.Z = c.R - (c.Q - (c.Q & 1)) / 2;
            c.Y = -c.X - c.Z;
            return c;
        }
        private static Coord OddRToCube(Coord c)
        {
            c.X = c.Q - (c.R - (c.R & 1)) / 2;
            c.Z = c.R;
            c.Y = -c.X - c.Z;
            return c;
        }
        #endregion
    }
}
