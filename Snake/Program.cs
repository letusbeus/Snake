﻿using System;
using System.Collections.Generic;

namespace Snake
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            HorizontalLine upLine = new HorizontalLine(0,78,0, '+');
            upLine.Draw();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            downLine.Draw();
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            leftLine.Draw();
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            rightLine.Draw();

            Console.ReadLine();
        }
    }
}