
namespace OrderCalculator
{
    public class OrderTotal
    {
       
        public int Price1 { get; set; }

        public int Price2 { get; set; }

        public int Discount { get; set; }

        public string Country { get; set; }

        public int ProductTotal { get; set; }

        public  int getPrices(int lPrice1, int lPrice2)
        {
            
            if (lPrice1 >= 0 && lPrice2 >= 0)
            {
                Price1 = lPrice1;
                Price2 = lPrice2;
                return 1;
            }
            return 0;

        }

        public  int getDiscount(int lDiscount)
        {

            if (lDiscount >= 0 && lDiscount <= 100)
            {
                Discount = lDiscount;
                return Discount;
            }
            return 0;

        }

        public  bool getCountryName(string lCountry)
        {
            Country = lCountry;
            return true;
        }

        public bool IsTaxApplicable()
        {
            if (Country == "India")
            {
                ProductTotal = (Price1 + Price2) - Discount;
                return true;
            }
            else if (Country != "United States")
            {
                ProductTotal = (Price1 + Price2) - Discount;
            }
            else 
            {
                ProductTotal = Price1 + Price2;
            }
            return false;
        }

        public int OrderTotalPrice()
        {
            int total;
            if (IsTaxApplicable())
            {
                total = (int)(ProductTotal - (ProductTotal * 0.05));
                return total;
            }
            else
            {
                return ProductTotal; 
            }
        }
    }
}
