using System;
using System.Collections.Generic;
using System.Text;

namespace oopsproject
{
    class DeligateDemo1
    {
        public void addnums(int x, int y, int z)
        {
            Console.WriteLine ($" sum of given 3 no's is :{x+y+z}");
        }
        public static string sayhello(string name)
        {
            return $"hello { name},have a nice day! ";


        }
        static void Main()
        {
        }
    }
}
