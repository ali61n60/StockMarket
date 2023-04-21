using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket.Components
{
    public partial class UserControlLiveData : UserControl
    {
        public string SymbolName { get; set; }  //ضستا
        public string SymbolBaseName { get; set; }  //شستا
        public string BasePrice { get; set; }

        public string SellPrice { get; set; }
        public string BuyPrice { get; set; }
        public string StrikePrice { get; set; }
        public string DaysToApply { get; set; }
        public string ProfitInPercent { get; set; }
        public string Url { get; set; }
        public string UrlBase { get; set; }
        public UserControlLiveData()
        {
            InitializeComponent();
        }

       
    }
}
