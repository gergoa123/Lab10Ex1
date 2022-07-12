using System;

namespace Lab10Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            ContactLessCard CLC = new ContactLessCard();
            ClassicCard CC = new ClassicCard();

            POS pos = new POS();

            pos.Pay(10, phone);
            pos.Pay(20, (IContactFullPay) CLC);
            pos.Pay(25, (IContactLessPay)CLC);
            pos.Pay(30, CC);

        }
    }
}
