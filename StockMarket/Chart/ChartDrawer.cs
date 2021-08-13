using ModelStd;
using ServiceStd;
using ServiceStd.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockMarket.Chart
{
    public class ChartDrawer
    {
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        IStockInfo stocksInformation;

        public ChartDrawer(System.Windows.Forms.DataVisualization.Charting.Chart chart, IStockInfo stocksInformation)
        {
            this.chart = chart;
            this.stocksInformation = stocksInformation;
            this.chart.ChartAreas[0].AxisX.MajorGrid.Interval = 30;
        }

        public void Draw(List<PointData> data,string chartName)
        {
            chartName += new Random().Next(10000).ToString();
            if (addChartSeries(chartName))
            {
                configureChartSeries();
                addData(chartName, data);
            }
        }

        public void DrawRatio(string stockName1, string stockName2,bool adjustedPrice)
        {
            List<PointData> listStockData1;
            List<PointData> listStockData2;
            if (adjustedPrice)
            {
                listStockData1 = stocksInformation.GetAdjustedStockData(stockName1);
                listStockData1.Sort((a, b) => a.Date.CompareTo(b.Date));
                listStockData2 = stocksInformation.GetAdjustedStockData(stockName2);
                listStockData2.Sort((a, b) => a.Date.CompareTo(b.Date));
            }
            else
            {
                listStockData1 = stocksInformation.GetStockData(stockName1);
                listStockData1.Sort((a, b) => a.Date.CompareTo(b.Date));
                listStockData2 = stocksInformation.GetStockData(stockName2);
                listStockData2.Sort((a, b) => a.Date.CompareTo(b.Date));
            }
            
            List<PointData> listRatio = new List<PointData>();
            double maxRatio = 1;
            double lastRatio = 0.5;
            double ratio = 0.1;
            foreach (PointData pointData in listStockData1)
            {
                DateTime date = pointData.Date;
                PointData pointDataTemp = listStockData2.Find(x => x.Date == date);
                if (pointDataTemp != null)
                {
                    PointData pointDataRatio = new PointData();
                    pointDataRatio.Date = date;
                    ratio = pointData.Final / pointDataTemp.Final;
                    if (ratio > maxRatio)
                        maxRatio = ratio;
                    pointDataRatio.Final = ratio;
                    listRatio.Add(pointDataRatio);
                }
            }
            lastRatio = ratio;
            double percentToMax = (maxRatio - lastRatio) * 100 / maxRatio;
            //listBox1.Items.Clear();
            //listBox1.Items.Add("MaxRatio= " + maxRatio);
            //listBox1.Items.Add("CurrentRatio= " + lastRatio);
            //listBox1.Items.Add("percnt to max= " + percentToMax);
            Clear();

            addChartSeries("Ratio");
            configureChartSeries();
            addData("Ratio", listRatio);
        }

        public void Clear()
        {
            chart.Series.Clear();
        }

        private bool addChartSeries(string name)
        {
            Series serires = new Series(name);
            
                if (!chart.Series.Contains(serires))
                {
                try
                {
                    chart.Series.Add(serires);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }                
                }

            return false;
        }

        private void configureChartSeries()
        {
            // Set series chart type

            foreach (var serie in chart.Series)
            {
                serie.ChartType = SeriesChartType.Line;

                // Set the style of the open-close marks
                serie["OpenCloseStyle"] = "Triangle";

                // Show both open and close marks
                serie["ShowOpenClose"] = "Both";

                // Set point width
                serie["PointWidth"] = "1.0";

                // Set colors bars
                serie["PriceUpColor"] = "Green"; // <<== use text indexer for series
                serie["PriceDownColor"] = "Red"; // <<== use text indexer for series

                serie.MarkerStyle = MarkerStyle.Circle;
            }

        }

        private void addData(string seriesName, List<PointData> listData)
        {
            for (int i = 0; i < listData.Count; i++)
            {
                // adding date and high
                chart.Series[seriesName].Points.AddXY(listData[i].Date, listData[i].Final);
                // adding low
                //chart.Series[seriesName].Points[i].YValues[1] = listData[i].Min;
                //adding open
                //chart.Series[seriesName].Points[i].YValues[2] = double.Parse(listData[i].FirstPrice);
                // adding close
                //chart.Series[seriesName].Points[i].YValues[3] = double.Parse(listData[i].LastPrice);
            }
        }

    }
}
