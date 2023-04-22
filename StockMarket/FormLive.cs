using ServiceStd.LiveData;
using System.Windows.Forms;


namespace StockMarket
{

    public partial class FormLive : Form
    {
        private readonly string ParsUrl = "http://www.tsetmc.ir/tsev2/data/instinfodata.aspx?i=6110133418282108&c=44+";
        private readonly string GhadirUrl = "http://www.tsetmc.ir/tsev2/data/instinfofast.aspx?i=26014913469567886&c=39+";
        private readonly string ZagrosUrl = "http://www.tsetmc.ir/tsev2/data/instinfodata.aspx?i=13235547361447092&c=44+";
        private readonly string Zasta2018 = "http://cdn.tsetmc.com/api/BestLimits/17494496342776868";
        private int numberOfCalls = 0;

        private readonly TseLiveData tseLiveData;

        bool runRatio = false;


        public FormLive()
        {
            InitializeComponent();
            InitUserControlLiveData();
        }

        private void InitUserControlLiveData()
        {
            userControlLiveData1.SymbolName = "ضستا2018";
            userControlLiveData1.SymbolBaseName = "شستا";
            userControlLiveData1.BasePrice = "10";
            userControlLiveData1.SellPrice = "11";
            userControlLiveData1.BuyPrice = "12";
            userControlLiveData1.StrikePrice = "13";
            userControlLiveData1.DaysToApply = "14";
            userControlLiveData1.ProfitInPercent = "15";
            userControlLiveData1.Url = Zasta2018;
            userControlLiveData1.UrlBase = "";
            userControlLiveData1.liveDataWorker = new OptionLiveData(userControlLiveData1.Url);
            userControlLiveData1.UpdateData();
        }
    }


}
