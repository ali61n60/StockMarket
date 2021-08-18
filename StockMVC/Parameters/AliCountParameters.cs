using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
