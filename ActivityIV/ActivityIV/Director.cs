using ActivityIV.Builder;

namespace ActivityIV
{
    class Director
    {
        public void Create(SaleBuilder builder)
        {
            builder.BuildDiscount();
        }
    }
}
