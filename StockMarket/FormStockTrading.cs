using ModelStd.DB;
using ModelStd.DB.Stock;
using RepositoryStd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StockMarket
{
    public partial class FormStockTrading : Form
    {
        List<Shareholder> listShareholder;
        List<Symbol> listSymbol;
        public FormStockTrading()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            initComboboxName();
            initComboboxSymbols();            
        }

        private void initComboboxName()
        {
            StockDbContext stockDbContext = new StockDbContext();
            listShareholder = stockDbContext.Shareholders.ToList();
            foreach(Shareholder s in listShareholder)
            {
                comboBoxName.Items.Add(s.Name);
            }            
        }

        private void initComboboxSymbols()
        {
            StockDbContext stockDbContext = new StockDbContext();
            listSymbol = stockDbContext.Symbols.ToList();
            foreach (Symbol s in listSymbol)
            {
                comboBoxStockInfo.Items.Add(s.NamePersian);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            StockDbContext stockDbContext = new StockDbContext();
            Shareholder shareholder = listShareholder.Find(s => s.Name == comboBoxName.SelectedItem.ToString());
            Symbol stockInfo = listSymbol.Find(s => s.NamePersian == comboBoxStockInfo.SelectedItem.ToString());

            TradeType tradeType = radioButtonBuy.Checked ? TradeType.Buy : TradeType.Sell;
            int volume = int.Parse(textBoxVolume.Text);
            double pricePerShare = double.Parse(textBoxPricePerShare.Text);
            double totalPrice = double.Parse(textBoxTotalPrice.Text);
            DateTime date = dateTimePicker1.Value.Date;

            StockTrading newStockTrading = new StockTrading();
            newStockTrading.ShareholderId = shareholder.Id;
            newStockTrading.SymbolId = stockInfo.Id;
            newStockTrading.TradeType = tradeType;
            newStockTrading.Volume = volume;
            newStockTrading.PricePerShare = pricePerShare;
            newStockTrading.TotalPrice = totalPrice;
            newStockTrading.Date = date;

            try
            {
                stockDbContext.StockTradings.Add(newStockTrading);
                stockDbContext.SaveChanges();
                labelMessage.Text = "OK" + DateTime.Now.ToLongTimeString();
            }
            catch(Exception ex)
            {
                labelMessage.Text = ex.Message;
            }
        }
    }
}
