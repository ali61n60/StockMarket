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


       private List<StockPointData> ReadData()
        {
            List<StockPointData> listA = new List<StockPointData>();
            using (var reader = new StreamReader(@"C:\Users\test\Documents\TseClient 2.0\ghadir.csv",Encoding.Unicode))
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
           var listData= ReadData();
            listData.RemoveAt(0);
            Series price = new Series("price"); // <<== make sure to name the series "price"
            chart1.Series.Add(price);

            // Set series chart type
            chart1.Series["price"].ChartType = SeriesChartType.Candlestick;

            // Set the style of the open-close marks
            chart1.Series["price"]["OpenCloseStyle"] = "Triangle";

            // Show both open and close marks
            chart1.Series["price"]["ShowOpenClose"] = "Both";

            // Set point width
            chart1.Series["price"]["PointWidth"] = "1.0";

            // Set colors bars
            chart1.Series["price"]["PriceUpColor"] = "Green"; // <<== use text indexer for series
            chart1.Series["price"]["PriceDownColor"] = "Red"; // <<== use text indexer for series

            for (int i = 0; i < listData.Count; i++)
            {
                // adding date and high
                chart1.Series["price"].Points.AddXY(i, double.Parse(listData[i].MaxPrice));
                // adding low
                double low = double.Parse(listData[i].MinPrice);
                chart1.Series["price"].Points[i].YValues[1] = low;
                //adding open
                chart1.Series["price"].Points[i].YValues[2] = double.Parse(listData[i].FirstPrice);
                // adding close
                chart1.Series["price"].Points[i].YValues[3] = double.Parse(listData[i].LastPrice);
            }

        }
    }
}

