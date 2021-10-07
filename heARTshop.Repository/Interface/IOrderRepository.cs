using heARTshop.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace heARTshop.Repository.Interface
{
        public interface IOrderRepository
        {
            List<Order> getAllOrders();
            Order GetOrderDetails(BaseEntity model);
        }
}
