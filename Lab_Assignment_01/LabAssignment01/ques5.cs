using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment01
{
    internal class Ques5
    {
        public void method5()
        {
            int[] NumArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Elements in array before reverse: ");
            show(NumArray);
            for(int i=0;i< NumArray.Length/2;i++)
            {
                int temp = NumArray[i];
                NumArray[i] = NumArray[NumArray.Length - i - 1];
                NumArray[NumArray.Length - i - 1] = temp;
            }
            Console.Write("\nElements in array after reverse: ");
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
