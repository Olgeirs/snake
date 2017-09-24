using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine   : F
    {

        public HorizontalLine() { }

        public HorizontalLine(int xL, int xR, int y, char sym)
        {
            plist = new List<Point>();

            for (int x = xL; x <= xR; x++) {

                Point p = new Point(x, y, sym);
                plist.Add(p);

            }
        }
    }
}
