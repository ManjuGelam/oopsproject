using System;

namespace oopsproject
{
    class Constructore
    {
        Constructore()
        {
            Console.WriteLine("non static constructor");
        }
        static Constructore()
        {
            Console.WriteLine("static constructor");
        }
        static void Main()
        {
            Console.WriteLine("main method");
            Constructore c = new Constructore();
        }
    }
}
    

