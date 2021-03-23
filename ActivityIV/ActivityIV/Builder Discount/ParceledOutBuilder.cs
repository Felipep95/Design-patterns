using ActivityIV.Builder;
using ActivityIV.Class;

namespace ActivityIV.Concrete_Sales
{
    class ParceledOutBuilder : SaleBuilder
    {
        public ParceledOutBuilder()
        {
            _sale = new Sale();
        }

        public override void BuildDiscount()
        {
            _sale.addDiscount(0);
        }
    }
}
