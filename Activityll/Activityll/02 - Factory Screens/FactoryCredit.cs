using Activityll.Interface;
using Activityll.Payments_Screens;


namespace Activityll.Factory_Screens
{
    class FactoryCredit : IFactoryPaymentMethod
    {
        public IPaymentMethod getPaymentScreen()
        {
            return new Credit();
        }
    }
}
