using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    class ThrowDemo
    {
      
            static void Main()
            {
                Console.Write("Enter first  number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int b = int.Parse(Console.ReadLine());
                if (b % 2 > 0)
                {
                    throw new ApplicationException("Divisor can't be an odd number.");
                   
                }
                int c = a / b;
                Console.WriteLine("The result  is: " + c);
                Console.WriteLine("End of the Program.");
            }
        }


    }

