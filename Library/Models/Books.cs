using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Library.Models
{
    class Books
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        
        public int Count { get; set; }

        [Column(TypeName ="money")]
        public decimal Price { get; set; }
    }
}
