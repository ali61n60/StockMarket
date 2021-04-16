using ModelStd.DB.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModelStd.Carts
{
    public class Cart
    {
        public List<SymbolLine> Lines { get; set; } = new List<SymbolLine>();
        public virtual void AddItem(Symbol symbol, int quantity)
        {
            SymbolLine line = Lines
            .Where(s => s.Symbol.Id == symbol.Id)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new SymbolLine
                {
                    Symbol = symbol,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(Symbol symbol) =>
        Lines.RemoveAll(l => l.Symbol.Id == symbol.Id);
        public decimal ComputeTotalValue() =>
        Lines.Sum(e => e.Symbol.GroupId * e.Quantity);
        public virtual void Clear() => Lines.Clear();
    }
    public class SymbolLine
    {
        public int SymbolLineId { get; set; }
        public Symbol Symbol { get; set; }
        public int Quantity { get; set; }
    }
}
