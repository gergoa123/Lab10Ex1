using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10Ex1
{
    class ClassicCard : IContactFullPay
    {
        public void extractCard()
        {
            Console.WriteLine("Am extras card");
        }

        public void insertCard()
        {
            Console.WriteLine("Am introdus card");
        }
    }
}
