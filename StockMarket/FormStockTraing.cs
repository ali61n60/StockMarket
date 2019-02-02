using ModelStd.DB;
using ModelStd.DB.Stock;
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
        List<Shareholder> listShareholder;
        List<StockInfo> listStockInfo;
        public FormStockTraing()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            initComboboxName();
            initComboboxStockInfo();
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

        private void initComboboxStockInfo()
        {
            StockDbContext stockDbContext = new StockDbContext();
            listStockInfo = stockDbContext.StockInfos.ToList();
            foreach (StockInfo s in listStockInfo)
            {
                comboBoxStockInfo.Items.Add(s.NamePersian);
            }
        }
    }
}
