using Microsoft.EntityFrameworkCore;
using ModelStd.AspBook;
using ModelStd.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryStd.Database.Repository
{
    public class EFOrderRepository : IOrderRepository
    {
        private StockDbContext context;
        public EFOrderRepository(StockDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders
        .Include(o => o.Lines)
        .ThenInclude(l => l.Symbol);
        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Symbol));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }

    }
}
