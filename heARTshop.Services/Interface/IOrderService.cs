using heARTshop.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace heARTshop.Services.Interface
{
    public interface IOrderService
    {
        List<Order> getAllOrders();

        Order GetOrderDetails(BaseEntity model);
    }
}
