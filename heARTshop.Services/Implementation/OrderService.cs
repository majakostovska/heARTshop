using heARTshop.Domain.DomainModels;
using heARTshop.Repository.Interface;
using heARTshop.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace heARTshop.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRespository;
        public OrderService(IOrderRepository orderRespository)
        {
            this._orderRespository = orderRespository;
        }
        public List<Order> getAllOrders()
        {
            return this._orderRespository.getAllOrders();
        }

        public Order GetOrderDetails(BaseEntity model)
        {
            return this._orderRespository.GetOrderDetails(model);
        }
    }
}
