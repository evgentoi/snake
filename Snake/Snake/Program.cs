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

           Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(8, 10, '%');
            p3.Draw();

            Point p4 = new Point(2, 12, '^');
            p4.Draw();


            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            List<char> charList = new List<char>();
            charList.Add('$');
            charList.Add('%');
            charList.Add('#');
            charList.Add('^');

            foreach(char i in charList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
