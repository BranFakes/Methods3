using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static int count = 0; //declare / init

        static void Loop()
        {
            count = count + 1;
            Console.WriteLine("Loopping" + count); //counts by number how many loops it did.
            Loop(); //Infinate Loop
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Methods 3");

            Loop();

            Console.WriteLine("");
        }
    }
}
