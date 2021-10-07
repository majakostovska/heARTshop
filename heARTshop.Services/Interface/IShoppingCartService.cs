using heARTshop.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace heARTshop.Services.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDTO getShoppingCartInfo(string userId);
        bool DeleteProductFromShoppingCart(string userId, Guid id);
        bool Order(string userId);
    }
}
