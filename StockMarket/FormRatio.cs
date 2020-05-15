using ModelStd.LiveData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket
{
    
    public partial class FormRatio : Form
    {
        private string ParsUrl = "http://www.tsetmc.com/tsev2/data/instinfodata.aspx?i=6110133418282108&c=44+";
        private string GhadirUrl = "http://www.tsetmc.com/tsev2/data/instinfofast.aspx?i=26014913469567886&c=39+";
        private string ZagrosUrl = "http://www.tsetmc.com/tsev2/data/instinfodata.aspx?i=13235547361447092&c=44+";

        bool runRatio = true;

        public FormRatio()
        {
            InitializeComponent();                        
        }

        private void startLoop()
        {
            Thread loopTread = new Thread(() => run());
            loopTread.Start();
        }

        private void run()
        {
            double ghadirPrice;
            double zagrosPrice;
            double parsPrice;
            while (runRatio)
            {
                ghadirPrice = GetPrice(GhadirUrl);
                zagrosPrice = GetPrice(ZagrosUrl);
                parsPrice = GetPrice(ParsUrl);
                try
                {
                    labelGhGh.Text = (ghadirPrice / ghadirPrice).ToString();
                    labelGhPa.Text = (ghadirPrice / parsPrice).ToString();
                    labelGhZa.Text = (ghadirPrice / zagrosPrice).ToString();
                    labelPaGh.Text = (parsPrice / ghadirPrice).ToString();
                    labelPaPa.Text = (parsPrice / parsPrice).ToString();
                    labelPaZa.Text = (parsPrice / zagrosPrice).ToString();
                    labelZaGh.Text = (zagrosPrice / ghadirPrice).ToString();
                    labelZaPa.Text = (zagrosPrice / parsPrice).ToString();
                    labelZaZa.Text = (zagrosPrice / zagrosPrice).ToString();
                }
                catch(Exception ex)
                {

                }
                
                

            }

        }

        private double GetPrice(string url)
        {
            try
            {
                SymbolLiveData symbolLiveData = new SymbolLiveData(url);
                Task<SymbolData> symbolDataTask = symbolLiveData.GetLiveDataAsync();

                SymbolData symbolData = symbolDataTask.Result;

                return double.Parse(symbolData.TransactionPrice);
            }
            catch (Exception ex)
            {
                return 1;
            }
            
        }

        private void GetZagros()
        {

        }

        private void GetPars()
        {

        }

        private void buttonController_Click(object sender, EventArgs e)
        {
            if (runRatio)
            {
                runRatio = false;
                buttonController.Text = "Start";
            }
            else
            {
                runRatio = true;
                buttonController.Text = "Stop";
                startLoop();
            }
        }
    }
}
