using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Walls walls = new Walls(80, 25);
            walls.Draw();
            
            
            //
            // VerticalLine vl = new VerticalLine(0, 10, 5, '%');
            // Draw(vl);
            //
            // Point p = new Point(4, 5, '*');
            // Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            // Draw(fSnake);
            // Snake snake = (Snake)fSnake; // явное приведение типов
            //
            // HorizontalLine hl = new HorizontalLine(0, 5, 6, '&');
            //
            // List<Figure> figures = new List<Figure>();
            // figures.Add(fSnake);
            // figures.Add(vl);
            // figures.Add(hl);
            //
            // foreach (var f in figures)
            // {
            //     f.Draw();
            // }

            
            // отрисовка точки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();
            
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                
                Thread.Sleep(200);
            
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}
