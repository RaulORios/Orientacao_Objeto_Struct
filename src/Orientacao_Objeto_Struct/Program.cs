﻿using System;

namespace Orientacao_Objeto_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 20;

            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);

            Console.ReadKey();

        }
    }
}
