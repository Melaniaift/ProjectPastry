using System;
using System.Collections.Generic;
using System.Text;

namespace PASTRY.DomainEntities
{ //redenumim in ShoppingCart
    public class ShoppingCustomer
    {
        public ShoppingCustomer()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public int ShoppingNumber { get; set; }
        public Guid CustomerId { get; set; }
    }
}

