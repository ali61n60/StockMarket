using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ModelStd.DB.Stock;
using RepositoryStd;

namespace StockMarket.Components
{
    public partial class SymbolSelector : UserControl
    {
        private List<CustomGroupMember> groupMembers;
        private List<CustomGroup> customGroups;


        public SymbolSelector()
        {
            InitializeComponent();           

        }

        public void Init()
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
            comboBoxGroup_SelectedIndexChanged(null, null);
        }

        private void comboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            StockDbContext stockDbContext = new StockDbContext();
            comboBoxSymbol.Items.Clear();
            groupMembers = stockDbContext.CustomGroupMembers.Where(
                member => member.GroupId == customGroups[comboBoxGroup.SelectedIndex].Id).ToList();
            foreach(CustomGroupMember groupMember in groupMembers)
            {
                comboBoxSymbol.Items.Add(stockDbContext.Symbols.First(s=>s.Id==groupMember.SymbolId).NamePersian);
            }
            comboBoxSymbol.SelectedIndex = 0;
            Symbol temp= GetSelectedSymbol();
        }

        public Symbol GetSelectedSymbol()
        {
            StockDbContext stockDbContext = new StockDbContext();
            return stockDbContext.Symbols.First(s => s.NamePersian == comboBoxSymbol.SelectedItem.ToString());
        }
    }
}
