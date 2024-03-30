using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities
{
    public class CartItem:BaseEntity
    {
        //Create models for all tables in the database related to e-commerce
        [ForeignKey("CartId")]
        public Guid CartId { get; set; }
        public Cart Cart { get; set; }

        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        //another fields
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice { get; set; }

        

    }
}