using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake      : F
    {

        direction direction;

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
    }
}
