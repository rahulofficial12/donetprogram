using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment01
{
    internal class Ques10
    {
        public void method10()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };
            List<int> commonElements = new List<int>();
            Console.Write("Elements in array 1 : ");
            show(array1);
            Console.Write("\nElements in array 2 : ");
            show(array2);
            foreach (int num1 in array1)
            {
                foreach (int num2 in array2)
                {
                    if (num1 == num2)
                    {
                        commonElements.Add(num1);
                        break; // Once found, no need to continue inner loop
                    }
                }
            }

            Console.WriteLine("\nCommon elements:");
            foreach (int num in commonElements)
            {
                Console.Write(num + " ");
            }
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
