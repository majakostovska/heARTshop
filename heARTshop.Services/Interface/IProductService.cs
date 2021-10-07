
using heARTshop.Domain.DomainModels;
using heARTshop.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace heARTshop.Services.Interface
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetDetailsForProduct(Guid? id);
        void CreateNewProduct(Product p);
        void UpdeteExistingProduct(Product p);
        AddToShoppingCartDTO GetShoppingCartInfo(Guid? id);
        void DeleteProduct(Guid id);
        bool AddToShoppingCart(AddToShoppingCartDTO item, string userID);
    }
}
