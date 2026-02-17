using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class Params
    {
        public int SumNumber(params int[] arr)
        {
            int result = 0;

            foreach (int item in arr)
            {
                result += item;
            }

            return result;
        }


        //    Params p = new Params();
        //    int result = p.SumNumber(234, 4, 45, 565, 767, 8, 2);
        //    Console.WriteLine(result);  
    }
}
