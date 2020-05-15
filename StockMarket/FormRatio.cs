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

        bool runRatio = false;

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
            ReturnData ghadirPrice;
            ReturnData zagrosPrice;
            ReturnData parsPrice;
            string formatter = "#,#.0000#;(#,#.0000#)";
            while (runRatio)
            {
                try
                {
                ghadirPrice = GetPrice(GhadirUrl);
                zagrosPrice = GetPrice(ZagrosUrl);
                parsPrice = GetPrice(ParsUrl);

                if (ghadirPrice.resultOk && zagrosPrice.resultOk && parsPrice.resultOk)
                {
                        labelGhGh.Invoke((MethodInvoker)delegate {
                            labelGhGh.Text = (ghadirPrice.price / ghadirPrice.price).ToString(formatter);
                            labelGhPa.Text = (ghadirPrice.price / parsPrice.price).ToString(formatter);
                            labelGhZa.Text = (ghadirPrice.price / zagrosPrice.price).ToString(formatter);
                            labelPaGh.Text = (parsPrice.price / ghadirPrice.price).ToString(formatter);
                            labelPaPa.Text = "ghadr=" + ghadirPrice.price + " , zagros=" + zagrosPrice.price + "  ,pars=" + parsPrice.price+" , "+DateTime.Now.ToString();
                            labelPaZa.Text = (parsPrice.price / zagrosPrice.price).ToString(formatter);
                            labelZaGh.Text = (zagrosPrice.price / ghadirPrice.price).ToString(formatter);
                            labelZaPa.Text = (zagrosPrice.price / parsPrice.price).ToString(formatter);
                            labelZaZa.Text = (zagrosPrice.price / zagrosPrice.price).ToString(formatter);

                        });


                    }
                }
                catch(Exception ex)
                {

                }

                Thread.Sleep(5000);

            }

        }

        private ReturnData GetPrice(string url)
        {
            try
            {
                SymbolLiveData symbolLiveData = new SymbolLiveData(url);
                Task<SymbolData> symbolDataTask = symbolLiveData.GetLiveDataAsync();

                SymbolData symbolData = symbolDataTask.Result;

                return new ReturnData()
                {
                    price = double.Parse(symbolData.TransactionPrice),
                    resultOk = true
                };
            }
            catch (Exception ex)
            {
               return new ReturnData()
                {
                    price = 1,
                    resultOk = false
                };
            }
            
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

    class ReturnData
    {
        public double price;
        public bool resultOk;
    }
}
