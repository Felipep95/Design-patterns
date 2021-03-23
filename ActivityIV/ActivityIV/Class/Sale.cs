using System.Collections.Generic;

namespace ActivityIV.Class
{
    class Sale
    {
        private List<Product> _products = new List<Product>();
        private double _discount = 1;

        public void addDiscount(double percents)
        {
            _discount = 1 - (percents / 100);
            _discount = (_discount < 0 ? 0 : _discount);
        }

        public void addProduct(Product product)
        {
            _products.Add(product);
        }

        public double getPrice()
        {
            double total = 0;
            double discount = 0;
            
            foreach (var p in _products)
                total += p.Price;

            return total * _discount;
        }
    }
}
