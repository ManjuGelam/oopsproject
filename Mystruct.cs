using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    struct Mystruct
    {
       
            int x;
            public Mystruct(int x)
            {
                this.x = x;
            }
            public void Display()
            {
                Console.WriteLine("Method defined under a structure: " + x);
            }
            static void Main()
            {
            Mystruct m1 = new Mystruct(); m1.Display();
            Mystruct m2; m2.x = 10; m2.Display();
            Mystruct m3 = new Mystruct(20); m3.Display();
                Console.ReadLine();
            }
        }
    }



