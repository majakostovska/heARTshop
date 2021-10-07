using heARTshop.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heARTshop.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public Guid Id { get; set; }
            public string UserId { get; set; }
            public heARTshopApplicationUser User { get; set; }
            public IEnumerable<ProductInOrder> ProductInOrders { get; set; }

        
    }
}
