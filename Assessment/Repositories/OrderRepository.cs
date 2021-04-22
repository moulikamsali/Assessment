using System.Collections.Generic;
using System.Linq;
using Assessment.Models;
using Assessment.Repositories;

namespace AspnetCoreEFCoreExample.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrdersDBContext _ctx;

        public OrderRepository(OrdersDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Order> GetAll()
        {
            return _ctx.Orders;
        }

        public Order GetSingle(int id)
        {
            return _ctx.Orders.FirstOrDefault(x => x.Id == id);
        }

        public Order Add(Order toAdd)
        {
            _ctx.Orders.Add(toAdd);
            return toAdd;
        }

        public Order Update(Order toUpdate)
        {
            _ctx.Orders.Update(toUpdate);
            return toUpdate;
        }

        public void Delete(Order toDelete)
        {
            _ctx.Orders.Remove(toDelete);
        }

        public int Save()
        {
            return _ctx.SaveChanges();
        }
    }
}
