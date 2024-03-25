using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PASTRY.DomainEntities
{
    public class Drink
    {
        public int Id { get; set; }
        public int IdImage { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageDrink { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
