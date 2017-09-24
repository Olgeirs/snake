using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine    : F
    {

        public VerticalLine() { }


        public VerticalLine(int x, int y1, int y2, char sym) {

            plist = new List<Point>();

            for (int y = y1; y <= y2; y++) {
                Point p = new Point(x,y,sym);
                plist.Add(p);
            }
        }

    }
}
