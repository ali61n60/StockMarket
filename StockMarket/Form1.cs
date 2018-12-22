using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StockMarket.Model;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //PARK1
       private List<StockPointData> ReadData(string fileName)
        {
            List<StockPointData> listA = new List<StockPointData>();
            using (var reader = new StreamReader(fileName, Encoding.Unicode))
            {                
                StockPointData tempPoint;
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    tempPoint = new StockPointData();
                    tempPoint.StockName = values[0];
                    tempPoint.Date = values[1];
                    tempPoint.FirstPrice = values[2];
                    tempPoint.MaxPrice = values[3];
                    tempPoint.MinPrice = values[4];
                    tempPoint.FinalPrice = values[5];
                    tempPoint.Voume = values[6];
                    tempPoint.Value = values[7];
                    tempPoint.NumberOfDeals = values[8];
                    tempPoint.YesterdayPrice = values[9];
                    tempPoint.CompanyCode = values[10];
                    tempPoint.LatinName = values[11];
                    tempPoint.CompanyName = values[12];
                    tempPoint.Date2 = values[13];
                    tempPoint.LastPrice = values[14];
                    listA.Add(tempPoint);                    
                }
            }
            return listA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ghadir = @"C:\Users\test\Documents\TseClient 2.0\GDIR1.csv";
            string sharak = @"C:\Users\test\Documents\TseClient 2.0\PARK1.csv";
            ClearChartSeries();
            AddChartSeries();
            ConfigureChartSeries();

            List<StockPointData> listGhadir = ReadData(ghadir);
            listGhadir.RemoveAt(0);
            
            List<StockPointData> listSharak = ReadData(sharak);
            listSharak.RemoveAt(0);

            List<StockPointData> listGhadirSharakRatio = new List<StockPointData>();
            for(int i=0;i<listGhadir.Count && i < listSharak.Count; i++)
            {
                if(double.Parse(listSharak[i].FinalPrice)!=0)
                {
                    StockPointData ratioPoint = new StockPointData();
                    double gadir = double.Parse(listGhadir[i].FinalPrice);
                    double sharak2 = double.Parse(listSharak[i].FinalPrice);
                    double finalPrice = 10000*gadir / sharak2;
                    ratioPoint.FinalPrice = finalPrice.ToString();
                    listGhadirSharakRatio.Add(ratioPoint);
                }
            }
            
            AddData("Ghadir", listGhadir);
            AddData("Sharak", listSharak);
            AddData("Ratio", listGhadirSharakRatio);

            

        }

        private void AddData(string seriesName, List<StockPointData> listData)
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

