using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment01
{
    internal class Ques1
    {
        public void method1() {
            int[] NumArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            Console.Write("Elements in array : ");
            foreach (int num in NumArray)
            {
                Console.Write(num+" ");
                sum += num;
            }
            Console.WriteLine("\nSum of elements in array : "+sum);
        }  
        


    }
}
