using System;

namespace Abstraction.Interface
{
    public class INokia : ISmartphone
    {
        public void Merk()
        {
            Console.WriteLine("Nokia dulu menjadi primadona dengan kualitas kerja tertinggi dibanding smartphone lain");
            Console.WriteLine("Tapi kini, karena penolakan nokia terhadap android.");
            Console.WriteLine("Nokia sekarang seperti tidak di akui lagi");
        }
    }
}
