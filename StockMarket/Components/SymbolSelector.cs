using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelStd.DB.Stock;
using RepositoryStd;

namespace StockMarket.Components
{
    public partial class SymbolSelector : UserControl
    {
        private List<Symbol> symbols;
        private List<CustomGroup> customGroups;

        //public Symbol SelectedSymbol { get { return comboBoxSymbol.SelectedValue} }
        public SymbolSelector()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            initCumboboxGroup();
            

        }

        private void initCumboboxGroup()
        {
            StockDbContext stockDbContext = new StockDbContext();
            customGroups = stockDbContext.CustomGroups.ToList();
            foreach (CustomGroup group in customGroups)
            {
                comboBoxGroup.Items.Add(group.Name);
            }
            comboBoxGroup.SelectedIndex = 0;
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
