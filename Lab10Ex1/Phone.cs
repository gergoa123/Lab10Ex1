using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10Ex1
{
    class Phone : IContactLessPay
    {
        public void TouchTheSensor()
        {
            Console.WriteLine("Am atins sensorul cu telefonul");
        }
    }
}
