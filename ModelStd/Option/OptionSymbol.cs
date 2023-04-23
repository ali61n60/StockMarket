using System;
using System.Collections.Generic;
using System.Text;

namespace ModelStd.Option
{
    public class OptionSymbol
    {
        public string SymbolName { get; set; }
        public DateTime EnforcementDate { get; set; }
        public double StrikePrice { get; set; }
        public double BaseStockPrice;
        public string TseId { get; set; }
        public string Url { get; }
    }
}
