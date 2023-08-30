using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment01
{
    internal class Ques4
    {
        public void method4()
        {
            int[] ArrayNumber = { 12, 23, 34, 45, 56, 67, 78, 89, 90 };
            int EvenCount = 0, OddCount = 0;
            Console.Write("Elements in array : ");
            foreach (int num in ArrayNumber)
            {
                Console.Write(num + " ");
                if (num%2==0)
                { 
                    EvenCount++; 
                }
                else 
                { 
                    OddCount++; 
                }
            }
            Console.WriteLine("\nNumber of even value in array : " + EvenCount);
            Console.WriteLine("Number of odd value in array : " + OddCount);
        }
        
    }
}
