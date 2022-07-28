using FrackerHub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrackerHub.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetUserOrders(int Id);
    }
}
