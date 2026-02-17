using System;
using System.Collections.Generic;
using System.Text;

namespace C__practice
{
    public class Average_Of_Array
    {
        public int CalculateSum(int[] array)
        {
            int result = 0;
            foreach (int value in array)
            {
                result += value;
            }
            return result;
        }

        public double CalculareAverage(int[] arr)
        {
            int sum = CalculateSum(arr);  // Call sum function
            double average = (double)sum / arr.Length;
            return average;
        }

        public void DisplayArray(int[] arr)
        {
            Console.Write("Array elements: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }




    }
}
