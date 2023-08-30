using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment01
{
    internal class Ques9
    {
        public void method9()
        {
            int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };
            List<int> uniqueNumbers = new List<int>();
            Console.Write("Elements in array : ");
            show(numbers);
            foreach (int num in numbers)
            {
                if (!uniqueNumbers.Contains(num))
                {
                    uniqueNumbers.Add(num);
                }
            }

            Console.Write("\nArray after removing duplicates:");
            foreach (int num in uniqueNumbers)
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
