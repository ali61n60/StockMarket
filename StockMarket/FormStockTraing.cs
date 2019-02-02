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
    public partial class FormStockTraing : Form
    {
        public FormStockTraing()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            initComboboxName();
        }

        private void initComboboxName()
        {
            StockDbContext stockDbContext = new StockDbContext();
            List<Shareholder> shareholders = stockDbContext.Shareholders.ToList();
            foreach(Shareholder s in shareholders)
            {
                comboBoxName.Items.Add(s.Name);
            }
            
        }
    }
}
