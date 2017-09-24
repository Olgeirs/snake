using System;
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

            Console.SetBufferSize(80, 25);

            HorizontalLine uline = new HorizontalLine(0, 78, 0, '-');
            HorizontalLine dline = new HorizontalLine(0, 78, 24, '-');
            VerticalLine lline = new VerticalLine(0, 0, 24, '|');
            VerticalLine rline = new VerticalLine(78, 0, 24, '|');

            uline.Draw();
            dline.Draw();
            lline.Draw();
            rline.Draw();



            Console.ReadLine();
        }


    }
}
