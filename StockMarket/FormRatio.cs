using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ModelStd;
using ServiceStd;
using ServiceStd.Indicators;
using RepositoryStd;
using System.Linq;
using ModelStd.DB.Stock;
using Microsoft.EntityFrameworkCore;
using StockMarket.Chart;

namespace StockMarket
{
    public partial class FormRatio : Form
    {
        StocksInformation stocksInformation;
        ChartDrawer chartDrawer ;
        public FormRatio()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            stocksInformation = new StocksInformation();
            initComboBoxList();
            initCumboBoxStocksName();
            initChartDrawer();
        }

        private void initComboBoxList()
        {
            
            StockDbContext dbContext = new StockDbContext();
            List<CustomGroup> stockList = dbContext.CustomGroups.ToList();
            foreach(CustomGroup s in stockList)
            {
                comboBoxStockGroup.Items.Add(s.Name);
            }
            comboBoxStockGroup.SelectedIndex = 0;
        }
        private void initCumboBoxStocksName()
        {
            foreach (string stockName in stocksInformation.GetAllStocksName())
            {
                comboBoxStockList1.Items.Add(stockName);
                comboBoxStockList2.Items.Add(stockName);
            }
            comboBoxStockList1.SelectedIndex = 0;
            comboBoxStockList2.SelectedIndex = 0;

        }

        private void initChartDrawer()
        {
            chartDrawer = new ChartDrawer(chart1,stocksInformation);
        }


        private void buttonSeries1_Click(object sender, EventArgs e)
        {
            string stockName = comboBoxStockList1.SelectedItem.ToString();
            List<PointData> listStockData = stocksInformation.GetStockData(stockName);
            chartDrawer.Draw(listStockData, stockName);            
        }
        
       

        private void buttonSeries2_Click(object sender, EventArgs e)
        {
            string stockName = comboBoxStockList2.SelectedItem.ToString();
            List<PointData> listStockData = stocksInformation.GetStockData(stockName);
            chartDrawer.Draw(listStockData, stockName);            
        }

        private void buttonRatio_Click(object sender, EventArgs e)
        {
            string stockName1 = comboBoxStockList1.SelectedItem.ToString();
            string stockName2 = comboBoxStockList2.SelectedItem.ToString();

            chartDrawer.DrawRatio(stockName1, stockName2);

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StockStatictics stockStatictics = new StockStatictics();
            string stockName = comboBoxStockList1.SelectedItem.ToString();
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
            foreach (var item in comboBoxStockList1.Items)
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

        

        int average = 7;
        private void buttonAverage_Click(object sender, EventArgs e)
        {
            string stockName = comboBoxStockList1.SelectedItem.ToString();
            List<PointData> listStockData = stocksInformation.GetStockData(stockName);

            
            List<PointData> listMovingAverage = new Averages().MovingAverage(listStockData, average);

            
            //addChartSeries("MA[" + average + "]" + stockName);
            //configureChartSeries();
            //addData("MA[" + average + "]" + stockName, listMovingAverage);
            average+=10;
        }

        private void comboBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockDbContext stockDbContext = new StockDbContext();
            string selectdListName = comboBoxStockGroup.SelectedItem.ToString();
            var temp = stockDbContext.CustomGroups.Where(s => s.Name == selectdListName);
            int listId = stockDbContext.CustomGroups.Where(s => s.Name == selectdListName).First().Id;
            List<CustomGroupMember> stockListStockInfo = stockDbContext.CustomGroupMembers
                .Include(s=>s.Symbol)
                .Where(s => s.GroupId == listId).ToList();
            comboBoxStockList1.Items.Clear();
            comboBoxStockList2.Items.Clear();
            foreach (CustomGroupMember s in stockListStockInfo)
            {
                comboBoxStockList1.Items.Add(s.Symbol.NamePersian);
                comboBoxStockList2.Items.Add(s.Symbol.NamePersian);
            }
        }

        private void buttonAverageVolume_Click(object sender, EventArgs e)
        {
            string stockName = comboBoxStockList1.SelectedItem.ToString();
            List<PointData> listStockData = stocksInformation.GetStockData(stockName);

            int numberOfDays = int.Parse(textBoxNumberOfDays.Text);

            Volume volume = new Volume();
            int averageVolume = volume.CalculateAverageVolume(listStockData, numberOfDays);

            listBox1.Items.Add(stockName + " Average Volume in Last " + numberOfDays + " Day[s] is " + averageVolume);
        }
    }

    class Message
    {
        public string StockName;
        public double value;
    }
}

