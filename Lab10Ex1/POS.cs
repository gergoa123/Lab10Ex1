using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10Ex1
{
    class POS
    {
        public void Pay(int sum, IContactLessPay payment)
        {
            payment.TouchTheSensor();
            Console.WriteLine("Am efectuat plata de " + sum);
        }

        public void Pay(int sum,IContactFullPay payment)
        {
            payment.insertCard();
            Console.WriteLine("Am edectut plata de " + sum);
            payment.extractCard();
        }
    }
}
