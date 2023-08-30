using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment01
{
    internal class Ques7
    {
        public void method7()
        {
            int[] NumArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int num = 5, found = -1;
            Console.Write("Elements in array : ");
            show(NumArray);
            Console.WriteLine("\n"+num + " is to be searched in given array");
            for (int i = 0; i < NumArray.Length; i++)
            {
                if (NumArray[i] == num)
                {
                    Console.WriteLine(num + " is found at " + (i + 1) + " position");
                    found = 0;
                    break;
                }
            }
            if (found == -1)
                Console.WriteLine(num + " is not found");
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
