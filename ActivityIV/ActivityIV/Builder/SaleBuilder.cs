using ActivityIV.Class;

namespace ActivityIV.Builder
{
    abstract class SaleBuilder
    {
        protected Sale _sale;

        public Sale Sale
        {
            get { return _sale; }
        }

        
        public abstract void BuildDiscount();
        
    }
}
