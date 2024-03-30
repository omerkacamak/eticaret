using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities
{
    public class Cart:BaseEntity
    {
        //Create models for all tables in the database related to e-commerce
        [ForeignKey("UserId")]
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<CartItem>? CartItems { get; set; }
    }
}