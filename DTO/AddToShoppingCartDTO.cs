﻿
using heARTshop.Domain.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heARTshop.Domain.DTO
{
    public class AddToShoppingCartDTO
    {
            public Product SelectedProduct { get; set; }
            public Guid ProductId { get; set; }
            public int Quantity { get; set; }
    }
}
