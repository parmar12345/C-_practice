using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    internal class Array
    {

        public int a = 10;
        // array with method
        public int Sum(int[] array)
        {
            int result = 0;
            foreach (int value in array)
            {
                result += value;
            }
            return result;
        }

        // return type array

        public int[] ArrayForNumber(int a, int b, int c)
        {
            int[] result = new int[3];
            result[0] = a;
            result[1] = b;
            result[2] = c;

            return result;
        }


        




        //Array arr = new Array();
        //int result = arr.Sum(new int[] { 4, 3, 2, 1, 4, 12, 2 });
        //Console.WriteLine(result);



        //    int[] ArryaResult = arr.ArrayForNumber(3, 4, 5);
        //Console.WriteLine(ArryaResult);
    }
}
