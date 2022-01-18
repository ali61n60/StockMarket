using ModelStd;
using ServiceStd.IService;
using System;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockMarket.Chart
{
    public class ChartDrawer
    {
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        ISymbolService _symbolService;

        public ChartDrawer(System.Windows.Forms.DataVisualization.Charting.Chart chart, ISymbolService symbolService)
        {
            this.chart = chart;
            this._symbolService = symbolService;
            this.chart.ChartAreas[0].AxisX.MajorGrid.Interval = 30;
        }

        public void Draw(int symbolId,bool adjustedPrice)
        {
            List<PointData> listStockData;
            if (adjustedPrice)
            {
                listStockData = _symbolService.GetAdjustedSymbolTradekData(symbolId);
            }
            else
            {
                listStockData = _symbolService.GetSymbolTradeData(symbolId);
            }

            Draw(listStockData,"SymbolName");
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

        public void DrawRatio(int symbolId1, int symbolId2,bool adjustedPrice)
        {   
            List<PointData> listRatio = _symbolService.GetRatio(symbolId1, symbolId2, adjustedPrice);
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
