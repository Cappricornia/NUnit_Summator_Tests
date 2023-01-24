using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        // Test method that sums the array of numbers
        public static long Sum(int[] arr)
        {
            long sum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }


        public static double Average(int[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                
            }
           
            return sum / arr.Length;
        }

        // This method is static as it doesn't create an object and void as it doesn't return anything, its perpose is to test the method above
        public static void Test_SumTwoNumbers()
        {
            if (Sum(new int[] { 1, 2 }) != 3)
            {
                throw new Exception("1+2 != 3");
            }
            else
            {
                Console.WriteLine("Test pass!");
            }


         }
            

    }
}
