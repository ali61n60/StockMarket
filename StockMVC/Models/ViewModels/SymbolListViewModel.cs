using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMVC.Models.ViewModels
{
    public class SymbolListViewModel
    {
        public IEnumerable<string> Symbols { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
