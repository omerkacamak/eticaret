using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities
{
    public class Category:BaseEntity
    {
        //All required fields for a category in an e-commerce database
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}