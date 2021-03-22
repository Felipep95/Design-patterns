using System;
using Activityll.Factory_Screens;
using Activityll.Interface;


namespace Activityll
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryPaymentMethod[] screens = new IFactoryPaymentMethod[3];

            screens[0] = new FactoryCredit();
            screens[1] = new FactoryDebit();
            screens[2] = new FactoryTicket();


            foreach(var screen in screens)
            {
                Console.WriteLine(screen.getPaymentScreen().GetType().Name);
            }

        }
    }
}