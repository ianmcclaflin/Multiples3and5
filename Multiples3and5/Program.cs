using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000; i++)
            {

                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                } 

                
            }


            List<int> numbers = new List<int>();
            for (int i = 3; i < 1000; i+= 3)
            {
                numbers.Add(i);
            }
            for (int j = 5 ; j < 1000; j+= 5)
            {
                numbers.Add(j);
            }
            
            int sum1 = numbers.Sum();
            Console.WriteLine("This is the sum of all 3 and 5 multiples from 0-1000");
            Console.WriteLine(sum1);
            
                

        }





        
    }
}
