using System;
using System.Collections.Generic;
using System.Text;

namespace PASTRY.DomainEntities
{
    public class Shopping
    {
        public int Number { get; set; }
        public Guid CustomerId { get; set; }
        public ShoppingStatus Status { get; set; }
    }
}
