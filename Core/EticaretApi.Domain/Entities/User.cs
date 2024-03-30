using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EticaretApi.Domain.Entities
{
    public class User:BaseEntity
    {
        //Create models for all tables in the database related to e-commerce

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //All necessary information for a user
        public string Username { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string ProfilePicture { get; set; }

        //tüm veritabanındaki yabancı anahtararı da düşünerek yeni fieldlar

        //foreign keys
        
        public Cart Cart { get; set; }
        //Does a customer order one or more? Create field accordingly
        public ICollection<Order>? Orders { get; set; }


    }
}