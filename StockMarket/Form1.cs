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
            }
            comboBox1.SelectedIndex = 0;
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string stockName= comboBox1.SelectedItem.ToString();
            List<PointData> listStockData= stocksInformation.GetStockData(stockName);
            clearChartSeries();
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
                chart1.Series[seriesName].Points.AddXY(listData[i].Date, double.Parse(listData[i].FinalPrice));
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

       
    }
}

