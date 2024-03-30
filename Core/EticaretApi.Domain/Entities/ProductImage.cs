using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities
{
    public class ProductImage:BaseEntity
    {
        //Create models for all tables in the database related to e-commerce
        public string ImageUrl { get; set; }
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

       

    }
}
