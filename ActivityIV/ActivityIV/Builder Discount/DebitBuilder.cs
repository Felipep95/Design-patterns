using ActivityIV.Builder;
using ActivityIV.Class;

namespace ActivityIV.Concrete_Sales
{
    class DebitBuilder : SaleBuilder
    {
        public DebitBuilder()
        {
            _sale = new Sale();
        }

        public override void BuildDiscount()
        {
            _sale.addDiscount(15);
        }
    }
}
