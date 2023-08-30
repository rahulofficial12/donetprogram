using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment01
{
    internal class Ques8
    {
        public void method8()
        {
            int[] numbers = { 5, 3, 8, 1, 10 };
            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;
            Console.Write("Elements in array : ");
            show(numbers);
            foreach (int num in numbers)
            {
                if (num < smallest)
                {
                    secondSmallest = smallest;
                    smallest = num;
                }
                else if (num < secondSmallest && num != smallest)
                {
                    secondSmallest = num;
                }
            }

            Console.WriteLine("\nSecond smallest element: " + secondSmallest);
        }
        public static void show(int[] a)
        {
            foreach (int num in a)
            {
                Console.Write(num + " ");
            }
        }
    }
}
