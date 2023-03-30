using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    class ConDemo
    {

        public ConDemo()//explicit constructor
        {
            Console.WriteLine("constructor is called");
        }
        public void Demo()
        {
            Console.WriteLine("method is called");
        }
        static void Main()
        {
            ConDemo cd1 = new ConDemo();
            ConDemo cd2 = new ConDemo();
            ConDemo cd3 = cd2;
            cd1.Demo();
            Console.ReadLine();
        }
    }
}

