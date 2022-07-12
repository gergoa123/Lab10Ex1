using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10Ex1
{
    class ContactLessCard : ClassicCard, IContactLessPay
    {
        public void TouchTheSensor()
        {
            Console.WriteLine("Ai atins sensorul cu card contact less");
        }
    }
}
