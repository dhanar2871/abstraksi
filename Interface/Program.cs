using System;
using Abstraction.Interface;

namespace Abstractionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            ISmartphone ismartphone;


            ismartphone = new INokia();
            ismartphone.Merk();

            Console.WriteLine();
            ismartphone = new Oppo();
            ismartphone.Merk();
            Console.ReadKey();
        }
    }
}
