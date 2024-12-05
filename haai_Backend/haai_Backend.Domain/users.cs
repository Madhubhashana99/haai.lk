using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace haai_Backend.Domain
{
    [Table("users")]
    public class User
    {
        public Guid id { get; set; }

        [MaxLength(50)]
        public string? name { get; set; }

        [MaxLength(50)]
        public string? userName { get; set; }

        [MaxLength(50)]
        public string? email { get; set; }

        [MaxLength(50)]
        public string? password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public role role{ get; set; }
    }
    public enum role 
    {
         Admin = 1,
         Customer = 2,
    }
}
