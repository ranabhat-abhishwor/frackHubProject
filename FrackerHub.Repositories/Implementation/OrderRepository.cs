using FrackerHub.Entities;
using FrackerHub.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrackerHub.Repositories.Implementation
{
    public class OrderRepository// : Repository<Order>, IOrderRepository
    {
        public IEnumerable<Order> GetUserOrders(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
