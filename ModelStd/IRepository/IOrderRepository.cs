using System.Linq;
using ModelStd.AspBook;

namespace ModelStd.IRepository
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
