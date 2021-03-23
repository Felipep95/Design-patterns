using ActivityIV.Builder;
using ActivityIV.Class;

namespace ActivityIV.Concrete_Sales
{
    class InCashBuilder : SaleBuilder
    {
        public InCashBuilder()
        {
            _sale = new Sale();
        }

        public override void BuildDiscount()
        {
            _sale.addDiscount(20);
        }
    }
}
