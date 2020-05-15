using ModelStd.DB;
using RepositoryStd;
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
    public partial class StockExchange : Form
    {
        List<Shareholder> listShareholder;
        public StockExchange()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            initComboboxName();
           // initComboboxStockInfo();
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
    }
}
