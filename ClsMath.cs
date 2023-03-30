using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    class ClsMath: Program, IMath1, IMath2
    {
       

  public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            ClsMath obj = new ClsMath();
            obj.Add(100, 34); obj.Sub(576, 287);
            obj.Mul(12, 38); obj.Div(456, 2);
            Console.ReadLine();
        }
    }


}

