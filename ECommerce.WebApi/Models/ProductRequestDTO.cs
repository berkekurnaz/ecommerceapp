using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebApi.Models
{
    public class ProductRequestDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string StockQuantity { get; set; }
        public string Category { get; set; }
    }
}
