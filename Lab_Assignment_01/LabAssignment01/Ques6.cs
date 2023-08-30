using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment01
{
    internal class Ques6
    {
        public void method6()
        {
            int[] NumArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int fact = 5;
            Console.Write("Elements in array before multiplication: ");
            show(NumArray);
            for (int i = 0; i < NumArray.Length; i++)
            {
                NumArray[i]*=fact;
            }
            Console.Write("\nElements in array after multiplicaation: ");
            show(NumArray);
            Console.WriteLine();
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
