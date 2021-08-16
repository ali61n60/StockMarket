using ModelStd;
using ModelStd.DB.Stock;
using System.Collections.Generic;

namespace StockMVC.Models.ViewModels
{
    public class SymbolListViewModel
    {
        public IEnumerable<Symbol> Symbols { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentSymbolGroup { get; set; }
        public List<PointData> ChartData { get; set; }
    }
}
