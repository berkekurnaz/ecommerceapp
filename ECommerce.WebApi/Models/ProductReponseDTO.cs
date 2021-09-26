using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebApi.Models
{
    public class ProductReponseDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StockQuantity { get; set; }
        public CategoryResponseDTO Category { get; set; }
    }
}
