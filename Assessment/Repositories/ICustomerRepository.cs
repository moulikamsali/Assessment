using System.Collections.Generic;
using Assessment.Models;

namespace Assessment.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer GetSingle(int id);
        Customer Add(Customer toAdd);
        Customer Update(Customer toUpdate);
        void Delete(Customer toDelete);
        int Save();
    }
}