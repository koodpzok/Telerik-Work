﻿using System;

namespace P04_FormattingNumbers
{
    class NumForm
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0,-10:X}|{1,-10}|{2,10:F2}|{3,-10:F3}|",a,Convert.ToString(a,2).PadLeft(10,'0'),b,c);
        }
    }
}
