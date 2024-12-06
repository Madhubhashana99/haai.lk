using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haai_Backend.Application.Model
{
    public class LoginRequest
    {
        public required string UserName { get; set; }
        public required string Password { get; set; }
    }
}
