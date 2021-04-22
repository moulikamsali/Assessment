using System.Collections.Generic;
using System.Linq;
using Assessment.Models;
using Assessment.Repositories;

namespace AspnetCoreEFCoreExample.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly OrdersDBContext _ctx;

        public CustomerRepository(OrdersDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _ctx.Customers;
        }

        public Customer GetSingle(int id)
        {
            return _ctx.Customers.FirstOrDefault(x => x.Id == id);
        }

        public Customer Add(Customer toAdd)
        {
            _ctx.Customers.Add(toAdd);
            return toAdd;
        }

        public Customer Update(Customer toUpdate)
        {
            _ctx.Customers.Update(toUpdate);
            return toUpdate;
        }

        public void Delete(Customer toDelete)
        {
            _ctx.Customers.Remove(toDelete);
        }

        public int Save()
        {
            return _ctx.SaveChanges();
        }
    }
}
