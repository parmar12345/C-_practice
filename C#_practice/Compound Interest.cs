using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class Compound_Interest
    {
        double principal, rate, time, amount, ci;
        internal void CI()
        {
            Console.Write("Enter Principal: ");
            principal = double.Parse(Console.ReadLine());

            Console.Write("Enter Rate of Interest: ");
            rate = double.Parse(Console.ReadLine());

            Console.Write("Enter Time (in years): ");
            time = double.Parse(Console.ReadLine());
        }

        internal void CI2()
        {
            amount = principal * Math.Pow((1 + rate/100),time);
            ci = amount - principal;

            Console.WriteLine("\nAmount = " + amount);
            Console.WriteLine("Compound Interest = " + ci);
        }
    }
}
