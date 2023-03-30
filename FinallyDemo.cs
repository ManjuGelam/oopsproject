using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    class FinallyDemo
    {
        static void Main()
            {
                try
                {
                    Console.Write("Enter first  number: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int y = int.Parse(Console.ReadLine());
                    if (y == 1)
                    {
                        return;
                    }
                    int z = x / y;
                    Console.WriteLine("The result of division is: " + z);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Finally block got executed.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("End of the Program.");
            }
        }

    }

