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
        public Guid Id { get; set; }

        [MaxLength (50)]
        public string Name { get; set; }

        [MaxLength (50)]
        public string Description { get; set; }

        [MaxLength (50)]
        public string CategoryId { get; set; }

        [MaxLength(50)]
        public string Price { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;


    }
}
