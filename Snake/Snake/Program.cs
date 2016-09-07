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

            HorizontalLine uline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine dline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rline = new VerticalLine(0, 24, 78, '+');
            uline.Draw();
            dline.Draw();
            lline.Draw();
            rline.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                System.Threading.Thread.Sleep(150);
                snake.Move();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                
                
            }
        }
    }
}
