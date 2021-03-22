using System;
using Activityll.Interface;

namespace Activityll.Payments_Screens
{
    class Ticket : IPaymentMethod
    {
        public double _Price;
        public void setPrice(double price)
        {
            _Price = price;
        }

        public void getPaymentScreen()
        {
            Console.WriteLine("Ticket Payment Screen");
        }
    }
}
