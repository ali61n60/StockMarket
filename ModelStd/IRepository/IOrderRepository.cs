using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModelStd.AspBook;

namespace ModelStd.IRepository
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
