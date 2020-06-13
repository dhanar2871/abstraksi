using System;

namespace Abstraction.Abstractclass
{
    public class Toshiba : Flashdisk
    {
        public override void Spesifikasi()
        {
            Console.WriteLine("Toshiba adalah flashdisk yang banyak digunakkan walaupun kecepatanya tergolong lambat");
            Console.WriteLine("Toshiba sangat di gemari saat ini di karenakkan harganya yang terbilang terjangkau");
        }
    }
}