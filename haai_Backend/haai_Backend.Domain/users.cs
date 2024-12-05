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
        public Guid Id { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        [MaxLength(50)]
        public string? UserName { get; set; }

        [MaxLength(50)]
        public string? Email { get; set; }

        [MaxLength(50)]
        public string? Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Role Role{ get; set; }
    }
    public enum Role 
    {
         Admin = 1,
         Customer = 2,
    }
}
