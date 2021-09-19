using System;

namespace StockMVC.Parameters
{
    public class AliCountParameters
    {
        public int currentCount = 399;
        
        public void Decrement()
        {
            Console.WriteLine("Calling");
            currentCount--;
        }
    }
}
