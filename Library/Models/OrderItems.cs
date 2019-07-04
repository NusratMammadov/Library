using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    class OrderItems
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int CustomrId { get; set; }
        public virtual Customer Customer { get; set; }

        public int BookId { get; set; }
        public virtual Books Books { get; set; }


        public double Count { get; set; }

        public double Price { get; set; }


        public DateTime Date { get; set; }
       
    }
}
