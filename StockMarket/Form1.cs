using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ModelStd;
using ModelStd.IRepository;
using ServiceStd;

namespace StockMarket
{
    public partial class Form1 : Form
    {
        StocksInformation stocksInformation;
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            stocksInformation = new StocksInformation();
            initCumboBoxStocksName();
        }

        private void initCumboBoxStocksName()
        {            
            foreach(string stockName in stocksInformation.GetAllStocksName())
            {
                comboBox1.Items.Add(stockName);
                comboBox2.Items.Add(stockName);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string stockName= comboBox1.SelectedItem.ToString();
            showData(stockName);      
        }

        private void showData(string stockName)
        {
            List<PointData> listStockData = stocksInformation.GetStockData(stockName);
            //clearChartSeries();
            addChartSeries(stockName);
            configureChartSeries();
            addData(stockName, listStockData);



            //List<PointData> listGhadirSharakRatio = new List<PointData>();
            //for(int i=0;i<listGhadir.Count && i < listSharak.Count; i++)
            //{
            //    if(double.Parse(listSharak[i].FinalPrice)!=0)
            //    {
            //        PointData ratioPoint = new PointData();
            //        double gadir = double.Parse(listGhadir[i].FinalPrice);
            //        double sharak2 = double.Parse(listSharak[i].FinalPrice);
            //        double finalPrice = 10000*gadir / sharak2;
            //        ratioPoint.FinalPrice = finalPrice.ToString();
            //        listGhadirSharakRatio.Add(ratioPoint);
            //    }
            //}

            //AddData("Ghadir", listGhadir);
            //AddData("Sharak", listSharak);
            //AddData("Ratio", listGhadirSharakRatio);  
        }

        private void addData(string seriesName, List<PointData> listData)
        {
            for (int i = 0; i < listData.Count; i++)
            {                
                // adding date and high
                chart1.Series[seriesName].Points.AddXY(listData[i].Date, listData[i].Final);
                // adding low
                //chart1.Series[seriesName].Points[i].YValues[1] = double.Parse(listData[i].MinPrice);
                //adding open
                //chart1.Series[seriesName].Points[i].YValues[2] = double.Parse(listData[i].FirstPrice);
                // adding close
                //chart1.Series[seriesName].Points[i].YValues[3] = double.Parse(listData[i].LastPrice);
            }
        }

        private void configureChartSeries()
        {
            // Set series chart type

            foreach(var sery in chart1.Series)
            {
                sery.ChartType = SeriesChartType.Line;

                // Set the style of the open-close marks
                sery["OpenCloseStyle"] = "Triangle";

                // Show both open and close marks
                sery["ShowOpenClose"] = "Both";

                // Set point width
                sery["PointWidth"] = "1.0";

                // Set colors bars
                sery["PriceUpColor"] = "Green"; // <<== use text indexer for series
                sery["PriceDownColor"] = "Red"; // <<== use text indexer for series
            }
            
        }

        private void addChartSeries(string name)
        {
            Series serires = new Series(name);
            chart1.Series.Add(serires);            
        }

        private void clearChartSeries()
        {
            chart1.Series.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stockName = comboBox2.SelectedItem.ToString();
            showData(stockName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string stockName1 = comboBox1.SelectedItem.ToString();
            string stockName2 = comboBox2.SelectedItem.ToString();

            List<PointData> listStockData1 = stocksInformation.GetStockData(stockName1);
            listStockData1.Sort((a, b) => a.Date.CompareTo(b.Date));
            List<PointData> listStockData2 = stocksInformation.GetStockData(stockName2);
            listStockData2.Sort((a, b) => a.Date.CompareTo(b.Date));
            List<PointData> listRatio = new List<PointData>();
            double maxRatio = 1;
            double lastRatio = 0.5;
            double ratio=0.1;
            foreach(PointData pointData in listStockData1)
            {
                DateTime date = pointData.Date;
                PointData pointDataTemp = listStockData2.Find(x => x.Date == date);
                if (pointDataTemp != null)
                {
                    PointData pointDataRatio = new PointData();
                    pointDataRatio.Date = date;
                    ratio= pointData.Final / pointDataTemp.Final;
                    if (ratio > maxRatio)
                        maxRatio = ratio;
                    pointDataRatio.Final = ratio;
                    listRatio.Add(pointDataRatio);
                }
            }
            lastRatio = ratio;
            double percentToMax = (maxRatio - lastRatio) * 100 / maxRatio;
            listBox1.Items.Clear();
            listBox1.Items.Add("MaxRatio= " + maxRatio);
            listBox1.Items.Add("CurrentRatio= " + lastRatio);
            listBox1.Items.Add("percnt to max= " + percentToMax);
            clearChartSeries();
            addChartSeries("Ratio");
            configureChartSeries();
            addData("Ratio", listRatio);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StockStatictics stockStatictics = new StockStatictics();
            string stockName = comboBox1.SelectedItem.ToString();
            int numberOfDays = int.Parse(textBoxNumberOfDays.Text);
            double maxPrice = stockStatictics.MaxPrice(stockName, numberOfDays);
            double minPrice = stockStatictics.MinPrice(stockName, numberOfDays);
            listBox1.Items.Add("for " + stockName + " in last " + numberOfDays + " days Max price is " + maxPrice + " and Min price is " + minPrice);
            
            

        }

        private void buttonPriceChange_Click(object sender, EventArgs e)
        {
            StockStatictics stockStatictics = new StockStatictics();
            List<Message> messages = new List<Message>();
            Message tempMesage;
            int numberOfDays = int.Parse(textBoxNumberOfDays.Text);
            foreach (var item in comboBox1.Items)
            {
                string stockName = item.ToString();
                double priceChange = stockStatictics.PriceChangePercent(stockName, numberOfDays);
                tempMesage = new Message();
                tempMesage.StockName = stockName;
                tempMesage.value = priceChange;
                messages.Add(tempMesage);
                
            }
            messages.Sort((m1, m2) => m1.value.CompareTo(m2.value));
            foreach (Message message in messages)
            {
                listBox1.Items.Add(message.StockName + " in last " + numberOfDays + " days price channge is " + message.value);
            }
            
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void ButtonUpdateStockName_Click(object sender, EventArgs e)
        {

        }
    }

    class Message
    {
        public string StockName;
        public double value;
    }
}

