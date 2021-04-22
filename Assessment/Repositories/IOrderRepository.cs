using System.Collections.Generic;
using Assessment.Models;

namespace Assessment.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        Order GetSingle(int id);
        Order Add(Order toAdd);
        Order Update(Order toUpdate);
        void Delete(Order toDelete);
        int Save();
    }
}