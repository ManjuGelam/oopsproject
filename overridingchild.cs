using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    class overridingchild : overridingparent
    {
        public void Test(int i)
        {
            Console.WriteLine("Child Class Test Method Is Called.");
        }
        static void Main()
        {
            overridingchild c = new overridingchild();
            c.Test();       //Executes parent class Test method
            c.Test(10);     //Executes child class Test method
            c.Show();           //Executes parent class Show method
            c.Display();    //Executes parent class Display method 
            Console.ReadLine();
        }

    }
}
