using Activityll.Interface;
using Activityll.Payments_Screens;

namespace Activityll.Factory_Screens
{
    class FactoryDebit : IFactoryPaymentMethod
    {
        public IPaymentMethod getPaymentScreen()
        {
            return new Debit();
        }
    }
}
