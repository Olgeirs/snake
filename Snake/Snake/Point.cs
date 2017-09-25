using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point() { }

        public Point(int _x, int _y, char _s )
        {
            x = _x;
            y = _y;
            sym = _s;

        }

        public Point(Point p) {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, direction direction) {

            if (direction == direction.right) {
                x = x + offset;
            } else if (direction == direction.left) {
                x = x - offset;
            } else if (direction == direction.up) {
                y = y - offset;
            } else if (direction== direction.down) {
                y = y + offset;
            }


        }

        public void Draw ()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear() {
            sym = ' ';
            Draw();
        }
    }
}
