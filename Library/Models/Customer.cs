using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string PhoneNo { get; set; }

        [Required]
        public string Email { get; set; }

        public ICollection<OrderItems> Orderitems { get; set; }
    }
}
