using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Added for MaxLengthAttribute


namespace haai_Backend.Domain
{
    [Table ("products")]
   public class Product
    {
        public Guid id { get; set; }

        [MaxLength (50)]
        public string name { get; set; }

        [MaxLength (50)]
        public string description { get; set; }

        [MaxLength (50)]
        public string categoryId { get; set; }

        [MaxLength(50)]
        public string price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}
