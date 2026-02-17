using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class SimpleIntrest
    {
        double p, r, t;
        internal void accept()
        {
            Console.WriteLine("Enter Principal amount:");
              p = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rate of interest:");
              r = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter time:");
              t = double.Parse(Console.ReadLine());
        }
        internal void SimInt()
        {
            double SI = p * r * t / 100;
            Console.WriteLine(SI);
        }
    }
}
