
using System;
using System.Collections.Generic;

namespace OrderCalculator
{
    public class OrderTotal
    {
        public static List<string> Countries = new List<string>()
        {
            "India", "United States", "Australia", "Russia"
        };

        public int Price1 { get; set; }

        public int Price2 { get; set; }

        public int Discount { get; set; }

        public string Country { get; set; }

        public int ProductTotal { get; set; }

        public  int getPrices(dynamic lPrice1, dynamic lPrice2)
        {
            int tempPrice1, tempPrice2;
            bool result1 = int.TryParse(Convert.ToString(lPrice1), out tempPrice1);
            bool result2 = int.TryParse(Convert.ToString(lPrice2), out tempPrice2);
            

            if((lPrice1!=null && result1) && (lPrice2!=null && result2))
            {
                if (tempPrice1 >= 0 && tempPrice2 >= 0)
                {
                    Price1 = tempPrice1;
                    Price2 = tempPrice1;
                    return 1;
                }
            }

            return 0;

        }

        public  int getDiscount(dynamic lDiscount)
        {
            int tempDiscount;
            bool result = int.TryParse(Convert.ToString(lDiscount), out tempDiscount);

            if(lDiscount!=null && result)
            {
                if (lDiscount >= 0 && lDiscount <= 100)
                {
                    Discount = tempDiscount;
                    return Discount;
                }
            }

            return 0;

        }

        public  bool getCountryName(dynamic countryName)
        {
            if(countryName != null)
            {
               if(Countries.Contains(countryName))
                {
                    return true;
                }
                return false;
            }
            return false;
           
        }

        public bool forDiscount()
        {

            if (Country == "United States")
            {
                ProductTotal = (Price1 + Price2);
                return true;
            }
            else 
            {
                ProductTotal = (Price1 + Price2) - Discount;
                return false;
            }
        }

        public bool IsTaxApplicable(string CountryName)
        {   
            if(Countries.Contains(CountryName))
            {
                double taxAmount;
                if(CountryName == "India")
                {
                    taxAmount = ProductTotal * 0.05;
                    return true;
                }
            }
            return false;
        }

        public bool OrderTotalPrice(string countryName)
        {
            int total;
            if (IsTaxApplicable(countryName))
            {
                total = (int)(ProductTotal - (ProductTotal * 0.05));
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}
