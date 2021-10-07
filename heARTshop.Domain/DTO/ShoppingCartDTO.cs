
using heARTshop.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heARTshop.Domain.DTO
{
    public class ShoppingCartDTO
    {
        public List<ProductInShoppingCart> ProductInShoppingCart { get; set; }
        public double TotalPrice { get; set; }
    }
}
