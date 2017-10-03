using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, direction.right);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {

                    ConsoleKeyInfo k = Console.ReadKey();

                    if (k.Key == ConsoleKey.LeftArrow)
                    {
                        snake.direction = direction.left;
                    }
                    else if (k.Key == ConsoleKey.RightArrow)
                    {
                        snake.direction = direction.right;
                    }
                    else if (k.Key == ConsoleKey.UpArrow)
                    {
                        snake.direction = direction.up;
                    }
                    else if (k.Key == ConsoleKey.DownArrow)
                    {
                        snake.direction = direction.down;
                    }
                }

                Thread.Sleep(100);
               snake.Move();
            }
        }
    }
}
