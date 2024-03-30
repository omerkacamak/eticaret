using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities
{
    public class Order:BaseEntity
    {
        //Create models for all tables in the database related to e-commerce
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        
        public string Address { get; set; }

    }
}