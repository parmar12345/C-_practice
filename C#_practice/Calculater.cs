using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class Calculater
    {
      public int a, b, c;

       internal void Accept()
        {
            Console.WriteLine("Enter Frist Number");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Frist Number");
            b = int.Parse(Console.ReadLine());

        }

        internal void add()
        {
            c = a + b;
            Console.WriteLine(c);
        }

         internal void sub()
        {
            c = a - b;
            Console.WriteLine(c);
        }

         internal void mul()
        {
            c = a * b;
            Console.WriteLine(c);
        }

        internal void div()
        {
            c = a / b;
            Console.WriteLine(c);
        }
    }
}
