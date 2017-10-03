using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake      : F
    {

        public direction direction;

        public Snake(Point t, int len, direction _direction)
        {
            direction = _direction;

            plist = new List<Point>();
            for (int i=0;i<=len;i++) {

                Point p = new Point(t);
                p.Move(i, direction);
                plist.Add(p);
            }
        }

        public void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);

            tail.Clear();
            head.Draw();


        }

        public Point GetNextPoint() {

            Point head = plist.Last();
            Point nextpoint = new Point(head);

            nextpoint.Move(1, direction);
            return nextpoint;
        }

        public void key(ConsoleKey k) {
            if (k == ConsoleKey.LeftArrow)
            {
                direction = direction.left;
            }
            else if (k == ConsoleKey.RightArrow)
            {
                direction = direction.right;
            }
            else if (k == ConsoleKey.UpArrow)
            {
                direction = direction.up;
            }
            else if (k == ConsoleKey.DownArrow)
            {
                direction = direction.down;
            }
        }
    }
}
