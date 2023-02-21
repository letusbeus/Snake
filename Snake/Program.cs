using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {

            VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            Draw(vl);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake; // явное приведение типов

            HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(vl);
            figures.Add(hl);

            foreach (var f in figures)
            {
                f.Draw();
            }

            // // отрисовка рамочки
            // HorizontalLine upLine = new HorizontalLine(0,78,0, '+');
            // upLine.Draw();
            // HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            // downLine.Draw();
            // VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            // leftLine.Draw();
            // VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            // rightLine.Draw();
            //
            // // отрисовка точки
            // Point p = new Point(4, 5, '*');
            // Snake snake = new Snake(p, 4, Direction.RIGHT);
            // snake.Draw();
            //
            // FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            // Point food = foodCreator.CreateFood();
            // food.Draw();
            //
            // while (true)
            // {
            //     if (snake.Eat(food))
            //     {
            //         food = foodCreator.CreateFood();
            //         food.Draw();
            //     }
            //     else
            //     {
            //         snake.Move();
            //     }
            //     
            //     Thread.Sleep(100);
            //
            //     if (Console.KeyAvailable)
            //     {
            //         ConsoleKeyInfo key = Console.ReadKey();
            //         snake.HandleKey(key.Key);
            //     }
            // }
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}
