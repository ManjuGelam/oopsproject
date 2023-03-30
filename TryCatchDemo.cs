using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    class TryCatchDemo
    {
        static void Main()
        {
            
            try
            {
                Console.Write("Enter 1st number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd number: ");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("The result of division is: " + z);
            }
            catch (DivideByZeroException)        //divide by zero exception
            {
                Console.WriteLine("division by zero is not possible");
            }

            catch (FormatException)            //format exception
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input values must  be integers.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("End of the Program.");
        }
    }

  

        }
    

