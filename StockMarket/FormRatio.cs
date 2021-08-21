using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ModelStd;
using ServiceStd;
using ServiceStd.Indicators;
using System.Linq;
using ModelStd.DB.Stock;
using StockMarket.Chart;
using ServiceStd.IService;
using ServiceStd.IOC;

namespace StockMarket
{
    public partial class FormRatio : Form
    {
        ISymbolService _symbolService;
        ISymbolGroupService _symbolGroupService;
        ICustomGroupService _customGroupService;
        ChartDrawer _chartDrawer ;
        
        List<CustomGroup> _customGroupList;
        List<SymbolGroup> _symbolGroupList;
        List<CustomGroupMember> _customGroupMembers;
        List<Symbol> _symbolGroupMembers;
        public FormRatio()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            _symbolService = Bootstrapper.container.GetInstance<ISymbolService>();
            _symbolGroupService = Bootstrapper.container.GetInstance<ISymbolGroupService>();
            _customGroupService= Bootstrapper.container.GetInstance<ICustomGroupService>();
            initComboBoxCustomGroup();
            initComboBoxCustomGroupMember();
            initComboBoxSymbolGroup();
            initComboBoxSymbolGroupMember();
            initChartDrawer();
        }

        private void initComboBoxCustomGroup()
        {
            _customGroupList = _customGroupService.GetAllGroups();
            foreach(CustomGroup c in _customGroupList)
            {
                comboBoxCustomGroup.Items.Add(c.Name);
            }
            comboBoxCustomGroup.SelectedIndex = 0;
        }
        private void initComboBoxCustomGroupMember()
        {
            comboBoxCustomGroupMember.Items.Clear();
            int selectedGroupId = _customGroupList.Where(s => s.Name == comboBoxCustomGroup.SelectedItem.ToString()).First().Id;
            _customGroupMembers = _customGroupService.GetMembers(selectedGroupId);
            foreach(CustomGroupMember c in _customGroupMembers)
            {
                comboBoxCustomGroupMember.Items.Add(c.Symbol.NamePersian);
            }           
            comboBoxCustomGroupMember.SelectedIndex = 0;
        }

        private void initComboBoxSymbolGroup()
        {
            _symbolGroupList= _symbolGroupService.GetAllSymbolGroups();
            foreach(SymbolGroup symbolGroup in _symbolGroupList)
            {
                comboBoxSymbolGroup.Items.Add(symbolGroup.Name);
            }
            comboBoxSymbolGroup.SelectedIndex = 0;
        }

        private void initComboBoxSymbolGroupMember()
        {
            comboBoxSymbolGroupMember.Items.Clear();
            int selectedGroupId = _symbolGroupList.Where(s => s.Name == comboBoxSymbolGroup.SelectedItem.ToString()).First().Id;
            _symbolGroupMembers = _symbolGroupService.GetMembers(selectedGroupId);
            foreach(Symbol s in _symbolGroupMembers)
            {
                comboBoxSymbolGroupMember.Items.Add(s.NamePersian);
            }
            comboBoxSymbolGroupMember.SelectedIndex = 0;
        }

        private void initChartDrawer()
        {
            _chartDrawer = new ChartDrawer(chart1,_symbolService);
        }

        private void buttonSeries1_Click(object sender, EventArgs e)
        {
            int symbolId = _customGroupMembers.Where(s => s.Symbol.NamePersian == comboBoxCustomGroupMember.SelectedItem.ToString()).First().SymbolId;
            
            _chartDrawer.Draw(symbolId, checkBoxAdjustedPrice.Checked);           
                 
        }
       
        private void buttonSeries2_Click(object sender, EventArgs e)
        {
            Symbol selectedSymbol = _symbolGroupMembers.Where(s => s.NamePersian == comboBoxSymbolGroupMember.SelectedItem.ToString()).First();
            int symbolId = selectedSymbol.Id;
            labelSymbolDetail.Text=$"{selectedSymbol.NamePersian} ,id={selectedSymbol.Id}";
            _chartDrawer.Draw(symbolId, checkBoxAdjustedPrice.Checked);
        }

        private void buttonRatio_Click(object sender, EventArgs e)
        {
            int symbolId1 = _customGroupMembers.Where(s => s.Symbol.NamePersian == comboBoxCustomGroupMember.SelectedItem.ToString()).First().SymbolId;
            int symbolId2 = _symbolGroupMembers.Where(s => s.NamePersian == comboBoxSymbolGroupMember.SelectedItem.ToString()).First().Id;
            _chartDrawer.DrawRatio(symbolId1, symbolId2, checkBoxAdjustedPrice.Checked);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StockStatictics stockStatictics = new StockStatictics();
            int symbolId = comboBoxCustomGroupMember.SelectedIndex;
            int numberOfDays = int.Parse(textBoxNumberOfDays.Text);
            double maxPrice = stockStatictics.MaxPrice(symbolId, numberOfDays);
            double minPrice = stockStatictics.MinPrice(symbolId, numberOfDays);
            listBox1.Items.Add("for " + symbolId + " in last " + numberOfDays + " days Max price is " + maxPrice + " and Min price is " + minPrice);



        }

        private void buttonPriceChange_Click(object sender, EventArgs e)
        {
            StockStatictics stockStatictics = new StockStatictics();
            List<Message> messages = new List<Message>();
            Message tempMesage;
            int numberOfDays = int.Parse(textBoxNumberOfDays.Text);
            foreach (var item in comboBoxCustomGroupMember.Items)
            {
                string stockName = item.ToString();
                double priceChange = stockStatictics.PriceChangePercent(1, numberOfDays);
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
            int symbolId = comboBoxCustomGroupMember.SelectedIndex;
            List<PointData> listStockData = _symbolService.GetSymbolTradeData(symbolId);

            
            List<PointData> listMovingAverage = new Averages().MovingAverage(listStockData, average);

            
            //addChartSeries("MA[" + average + "]" + stockName);
            //configureChartSeries();
            //addData("MA[" + average + "]" + stockName, listMovingAverage);
            average+=10;
        }

        private void comboBoxCustomGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            initComboBoxCustomGroupMember();
        }

        private void buttonAverageVolume_Click(object sender, EventArgs e)
        {
            int symbolId = comboBoxCustomGroupMember.SelectedIndex;
            List<PointData> listStockData = _symbolService.GetSymbolTradeData(symbolId);

            int numberOfDays = int.Parse(textBoxNumberOfDays.Text);

            Volume volume = new Volume();
            int averageVolume = volume.CalculateAverageVolume(listStockData, numberOfDays);

            listBox1.Items.Add(symbolId + " Average Volume in Last " + numberOfDays + " Day[s] is " + averageVolume);
        }

        private void comboBoxSymbolGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            initComboBoxSymbolGroupMember();
        }

       
    }

    class Message
    {
        public string StockName;
        public double value;
    }
}

