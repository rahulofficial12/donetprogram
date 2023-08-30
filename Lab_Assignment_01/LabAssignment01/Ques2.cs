using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment01
{
    internal class Ques2
    {
        public void method2()
        {
            float[] FloatArray = { 1.2f, 2.4f, 3.6f, 4.8f, 6.0f };
            float sum = 0;
            Console.Write("Elements in array : ");
            foreach (float num in FloatArray)
            {
                Console.Write(num + " ");
                sum += num;
            }
            Console.WriteLine("\nAverage of elements in array : " + sum/FloatArray.Length);
        }
    }
}
