using System;
using System.Collections.Generic;
using System.Text;
using ModelStd.Option;

namespace RepositoryStd.FileSystem.Option
{
    public class OptionChain
    {
        public List<OptionSymbol> AllOptionsChain { get; set; }
        public readonly string BaseLimit = "http://cdn.tsetmc.com/api/BestLimits/";
        public readonly string Closing = "http://cdn.tsetmc.com/api/ClosingPrice/GetClosingPriceInfo/";

        public readonly string Shasta = "http://www.tsetmc.com/tsev2/data/instinfofast.aspx?i=2400322364771558&c=39%2";
        private readonly string ParsUrl = "http://www.tsetmc.ir/tsev2/data/instinfodata.aspx?i=6110133418282108&c=44+";
        private readonly string GhadirUrl = "http://www.tsetmc.ir/tsev2/data/instinfofast.aspx?i=26014913469567886&c=39+";
        private readonly string ZagrosUrl = "http://www.tsetmc.ir/tsev2/data/instinfodata.aspx?i=13235547361447092&c=44+";

        
        public OptionChain()
        {
            AllOptionsChain = new List<OptionSymbol>();
            AllOptionsChain.Add(new OptionSymbol() { SymbolName = "Zasta2009", StrikePrice = 60, EnforcementDate = new DateTime(2023, 5, 3), TseId= "63594313188913737",TseBaseSymbolId= "2400322364771558" });
            AllOptionsChain.Add(new OptionSymbol() { SymbolName = "Zasta2010", StrikePrice = 70, EnforcementDate = new DateTime(2023, 5, 3), TseId = "28818775296415461", TseBaseSymbolId = "2400322364771558" });
            AllOptionsChain.Add(new OptionSymbol() { SymbolName = "Zasta2011", StrikePrice = 80, EnforcementDate = new DateTime(2023, 5, 3), TseId = "29498385890791708", TseBaseSymbolId = "2400322364771558" });
            AllOptionsChain.Add(new OptionSymbol() { SymbolName = "Zasta2012", StrikePrice = 90, EnforcementDate = new DateTime(2023, 5, 3), TseId = "58981618861615252", TseBaseSymbolId = "2400322364771558" });
            AllOptionsChain.Add(new OptionSymbol() { SymbolName = "Zasta2013", StrikePrice = 100, EnforcementDate = new DateTime(2023, 5, 3), TseId = "29654870107666638", TseBaseSymbolId = "2400322364771558" });
            AllOptionsChain.Add(new OptionSymbol() { SymbolName = "Zasta2014", StrikePrice = 110, EnforcementDate = new DateTime(2023, 5, 3), TseId = "14669878079087093", TseBaseSymbolId = "2400322364771558" });
            AllOptionsChain.Add(new OptionSymbol() { SymbolName = "Zasta2015", StrikePrice = 120, EnforcementDate = new DateTime(2023, 5, 3), TseId = "60164119629398850", TseBaseSymbolId = "2400322364771558" });
            AllOptionsChain.Add(new OptionSymbol() { SymbolName = "Zasta2016", StrikePrice = 130, EnforcementDate = new DateTime(2023, 5, 3), TseId = "2218242214087037", TseBaseSymbolId = "2400322364771558" });
            AllOptionsChain.Add(new OptionSymbol() { SymbolName = "Zasta2017", StrikePrice = 140, EnforcementDate = new DateTime(2023, 5, 3), TseId = "2358845259453973", TseBaseSymbolId = "2400322364771558" });
            AllOptionsChain.Add(new OptionSymbol() { SymbolName = "Zasta2018", StrikePrice = 150, EnforcementDate = new DateTime(2023, 5, 3), TseId = "17494496342776868", TseBaseSymbolId = "2400322364771558" });
            AllOptionsChain.Add(new OptionSymbol() { SymbolName = "Zasta2019", StrikePrice = 160, EnforcementDate = new DateTime(2023, 5, 3), TseId = "18174396556793835", TseBaseSymbolId = "2400322364771558" });
        }
    }
}
