using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;
using ModelStd.DB.Stock;
using RepositoryStd;
using System.Linq;

namespace StockMarketTests
{
    public class SymbolTest
    {

        [Test]
        public void Can_Create_Text_File_For_Building_Table_Data()
        {
            StockDbContext dbContext = new StockDbContext();
            Symbol[] symbols = dbContext.Symbols.ToArray();

            string path = @"c:\temp\Symbol.txt";
            File.WriteAllText(path, "\\[StockDb].[stock].[Symbol]" + Environment.NewLine);


            foreach (Symbol symbol in symbols)
            {
                string newDataRow = $"INSERT INTO [StockDb].[stock].[Symbol]  VALUES ({symbol.StockId} , '{symbol.SymbolPersian}','{ symbol.SymbolLatin}'"+
                    $" '{symbol.NameLatin}' , '{symbol.NamePersian}' , {symbol.GroupId})";
                File.AppendAllText(path, newDataRow + Environment.NewLine);
            }
            Assert.That(symbols.Length > 0);
        }
    }
}
