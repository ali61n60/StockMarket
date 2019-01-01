using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using ModelStd;

namespace StockMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            initCumboBoxStocksName();
        }

        private void initCumboBoxStocksName()
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string ghadir = @"C:\Users\test\Documents\TseClient 2.0\GDIR1.csv";
            string sharak = @"C:\Users\test\Documents\TseClient 2.0\PARK1.csv";
            ClearChartSeries();
            AddChartSeries();
            ConfigureChartSeries();

            //List<PointData> listGhadir = ReadData(ghadir);
           // listGhadir.RemoveAt(0);
            
           // List<PointData> listSharak = ReadData(sharak);
          //  listSharak.RemoveAt(0);

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

        private void AddData(string seriesName, List<PointData> listData)
        {
            for (int i = 0; i < listData.Count; i++)
            {                
                // adding date and high
                chart1.Series[seriesName].Points.AddXY(i, double.Parse(listData[i].FinalPrice));
                // adding low
                //chart1.Series[seriesName].Points[i].YValues[1] = double.Parse(listData[i].MinPrice);
                //adding open
                //chart1.Series[seriesName].Points[i].YValues[2] = double.Parse(listData[i].FirstPrice);
                // adding close
                //chart1.Series[seriesName].Points[i].YValues[3] = double.Parse(listData[i].LastPrice);
            }
        }

        private void ConfigureChartSeries()
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

        private void AddChartSeries()
        {
            Series ghadirSerires = new Series("Ghadir");
            chart1.Series.Add(ghadirSerires);

            Series sharakSeries = new Series("Sharak");
            chart1.Series.Add(sharakSeries);

            Series ratioSeries = new Series("Ratio");
            chart1.Series.Add(ratioSeries);
        }

        private void ClearChartSeries()
        {
            chart1.Series.Clear();
        }

       
    }
}

