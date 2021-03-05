using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceStd.Examples
{
    public class ShoppingCart
    {
        public List<Product> Products;
    }

    public class Product
    {
        public decimal Price;
    }


    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this ShoppingCart cartParam)
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
    }
}
