using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    class OverloadCons 
    {
      
        
            int i; bool b;
            public OverloadCons()
            {
              
            }
            public OverloadCons(int i)
            {
               
                this.i = i;
            }
            public OverloadCons(bool b)
            {
                
                this.b = b;
            }
            public OverloadCons(int i, bool b)
            {
               
                this.i = i;
                this.b = b;
            }
            public void Display()
            {
                Console.WriteLine($"Value of i is: {i} and value of b is: {b}");
            }
        }

    }

