using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class SwapProgram
    {
        static int a = 10,b=5;

        internal static void swap()
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a value is:"+ a + " " + "b value is:"+b);
        }
    }
}
