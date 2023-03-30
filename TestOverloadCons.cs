using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{

    class TestOverloadCons
    {
        static void Main()
        {
            OverloadCons c1 = new OverloadCons();
            c1.Display();
            OverloadCons c2 = new OverloadCons(10);
            c2.Display();
            OverloadCons c3 = new OverloadCons(true);
            c3.Display();
            OverloadCons c4 = new OverloadCons(10, true);
            c4.Display();
            Console.ReadLine();
        }
    }
}


    

