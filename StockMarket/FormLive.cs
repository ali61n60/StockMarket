﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStd.LiveData;


namespace StockMarket
{

    public partial class FormLive : Form
    {
        private readonly string ParsUrl = "http://www.tsetmc.ir/tsev2/data/instinfodata.aspx?i=6110133418282108&c=44+"; 
        private readonly string GhadirUrl = "http://www.tsetmc.ir/tsev2/data/instinfofast.aspx?i=26014913469567886&c=39+";
        private readonly string ZagrosUrl = "http://www.tsetmc.ir/tsev2/data/instinfodata.aspx?i=13235547361447092&c=44+";
        private int numberOfCalls = 0;

        private readonly TseLiveData tseLiveData;

        bool runRatio = false;

        
        public FormLive()
        {
            InitializeComponent();
            tseLiveData = new TseLiveData();
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
            double GhZaBest = double.Parse(textBoxGhZaBest.Text);
            double GhPaBest = double.Parse(textBoxGhPaBest.Text);
            string formatter = "#,#.0000#;(#,#.0000#)";
            while (runRatio)
            {
                try
                {
                    ghadirPrice = tseLiveData.GetPrice(GhadirUrl);
                    zagrosPrice = tseLiveData.GetPrice(ZagrosUrl);
                    parsPrice = tseLiveData.GetPrice(ParsUrl);

                    if (ghadirPrice.resultOk && zagrosPrice.resultOk && parsPrice.resultOk)
                    {
                        //TODO write data to excell file
                        labelGhGh.Invoke((MethodInvoker)delegate {
                            
                            labelGhGh.Text = (ghadirPrice.price / ghadirPrice.price).ToString(formatter);
                            labelGhPa.Text = (ghadirPrice.price / parsPrice.price).ToString(formatter);
                            labelGhZa.Text = (ghadirPrice.price / zagrosPrice.price).ToString(formatter);
                            labelPaGh.Text = (parsPrice.price / ghadirPrice.price).ToString(formatter);
                            labelPaPa.Text = (parsPrice.price / parsPrice.price).ToString(formatter);
                            labelPaZa.Text = (parsPrice.price / zagrosPrice.price).ToString(formatter);
                            labelZaGh.Text = (zagrosPrice.price / ghadirPrice.price).ToString(formatter);
                            labelZaPa.Text = (zagrosPrice.price / parsPrice.price).ToString(formatter);
                            labelZaZa.Text = (zagrosPrice.price / zagrosPrice.price).ToString(formatter);

                            labelSummary.Text= numberOfCalls+" ,ghadr=" + ghadirPrice.price + " , zagros=" + zagrosPrice.price + "  ,pars=" + parsPrice.price + " , " + DateTime.Now.ToString();
                            if ((ghadirPrice.price / zagrosPrice.price) > GhZaBest || GhZaBest / (ghadirPrice.price / zagrosPrice.price) > 1.03)
                            {
                                labelSummary.Text += " ,GhZa";
                            }
                            if ((ghadirPrice.price / parsPrice.price) > GhPaBest || GhPaBest / (ghadirPrice.price / parsPrice.price) > 1.03)
                            {
                                labelSummary.Text += " ,GhPa";
                            }
                            labelGhZatoBest.Text = ((ghadirPrice.price / zagrosPrice.price) / GhZaBest).ToString()+"   ,"+(0.97- ((ghadirPrice.price / zagrosPrice.price) / GhZaBest))*100;
                            labelGhPatoBest.Text= ((ghadirPrice.price / parsPrice.price) / GhPaBest).ToString() + "   ," + (0.97 - ((ghadirPrice.price / parsPrice.price) / GhPaBest)) * 100;
                        });
                    }
                    else
                    {
                        labelGhGh.Invoke((MethodInvoker)delegate {
                            labelSummary.Text += numberOfCalls+ " ,Error";
                        });
                    }
                }
                catch(Exception ex)
                {
                    labelGhGh.Invoke((MethodInvoker)delegate {
                        labelSummary.Text = ex.Message;
                    });
                }
                Thread.Sleep(10000);
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

   
}
