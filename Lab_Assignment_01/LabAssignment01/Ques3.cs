using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment01
{
    internal class Ques3
    {
        public void method3()
        {
            int[] Array = { 10,21,9,34,57,32,43,21,4 };
            int large = Array[0];
            Console.Write("Elements in array : ");
            foreach (int num in Array)
            {
                Console.Write(num + " ");
                if(num>large)
                {
                    large=num;
                }
            }
            Console.WriteLine("\nLargest element in array : " + large);
        }
    }
}
