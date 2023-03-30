using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    class overridingparent
    {
        public void Test()
        {
            Console.WriteLine("Parent Class Test Method Is Called.");
        }
        public virtual void Show()  //Overridable
        {
            Console.WriteLine("Parent Class Show Method Is Called.");
        }
        public void Display()
        {
            Console.WriteLine("Parent Class Display Method Is Called.");
        }
    }

}

