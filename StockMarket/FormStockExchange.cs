using ModelStd.DB;
using RepositoryStd;
using StockMarket.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket
{
    public partial class FormStockExchange : Form
    {
       
        List<Shareholder> listShareholder;
        public FormStockExchange()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            
            initComboboxName();
            initSold();
            initBought();
        }
        
        private void initComboboxName()
        {
            StockDbContext stockDbContext = new StockDbContext();
            listShareholder = stockDbContext.Shareholders.ToList();
            foreach (Shareholder s in listShareholder)
            {
                comboBoxName.Items.Add(s.Name);
            }
            if (comboBoxName.Items.Count > 0)
            {
                comboBoxName.SelectedIndex = 0;
            }
        }

        private void initSold()
        {
            symbolSelectorSold.Init();
        }

        private void initBought()
        {
            symbolSelectorBought.Init();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            //todo get data from form fields and put it in the database
            StockDbContext dbContext = new StockDbContext();
            FormStockExchange newStockExchange = new FormStockExchange();
            try
            {
                newStockExchange.
                //dbContext.StockExchanges.Add(null);

                labelMessage.Text = "Done at " + DateTime.Now.ToString();
            }
            catch(Exception ex)
            {

            }
            

        }
    }
}
