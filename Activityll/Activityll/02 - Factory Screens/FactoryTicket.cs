using Activityll.Interface;
using Activityll.Payments_Screens;

namespace Activityll.Factory_Screens
{
    class FactoryTicket : IFactoryPaymentMethod
    {
        public IPaymentMethod getPaymentScreen()
        {
            return new Ticket();
        }
    }
}
