using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelStd.DB.Stock;
using NUnit.Framework;
using RepositoryStd;
using System.IO;

namespace StockMarketTests
{
    class SymbolGroupTests
    {

        [Test]
        public void Can_Create_Text_File_For_Building_Table_Data()
        {
            StockDbContext dbContext = new StockDbContext();
            SymbolGroup[] symbolGroups= dbContext.SymbolGroups.ToArray();

            string path = @"c:\temp\SymbolGroup.txt";
            File.WriteAllText(path, "\\[StockDb].[stock].[SymbolGroup]" + Environment.NewLine);
                                              

            foreach (SymbolGroup symbolGroup in symbolGroups)
            {
                string newDataRow = "INSERT INTO [StockDb].[stock].[StockGroup]  VALUES ("+
                    symbolGroup.Id+",'"+symbolGroup.Name+"')";
                File.AppendAllText(path, newDataRow+Environment.NewLine);
            }
            Assert.That(symbolGroups.Length > 0);
        }
    }
}
