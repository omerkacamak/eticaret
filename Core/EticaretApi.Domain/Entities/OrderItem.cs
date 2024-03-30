using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities
{
    public class OrderItem:BaseEntity
    {
        //Create models for all tables in the database related to e-commerce
        [ForeignKey("OrderId")]
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        [ForeignKey("ProductId")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        //daha başka hangi fieldlar
        public decimal Discount { get; set; }
        public string Note { get; set; }

        

    }

}