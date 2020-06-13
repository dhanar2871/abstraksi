using System;
using Abstraction.Abstractclass;

namespace Abstractionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Flashdisk memory;

            memory = new VGen();
            memory.Spesifikasi();

            Console.ReadKey();
        }
    }
}
