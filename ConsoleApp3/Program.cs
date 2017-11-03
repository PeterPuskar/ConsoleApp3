using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

        {
            Dom mojDom = new Dom("Activ 1", "aktivni", "nie", 3, 30.9f, 74.8f);
            mojDom.PoskytniInformace();

            Console.WriteLine("Hello!");
            Console.ReadLine();


        }



    }
}
