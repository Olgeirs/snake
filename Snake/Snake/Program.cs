﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4,5,'$');
            p2.Draw();

            Point p3 = new Point();
            p3.x = 8;
            p3.y = 12;
            p3.sym = '&';
            p3.Draw();

            Point p4 = new Point(12, 15, '@');
            p4.Draw();


            List<Point> p = new List<Point>();
            p.Add(p1);
            p.Add(p2);
            p.Add(p3);
            p.Add(p4);





            Console.ReadLine();
        }


    }
}
