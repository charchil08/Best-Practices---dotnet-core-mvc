using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationDemo.DTO
{
    public class UserDTO
    {
        public long UserId { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Email { get; set; } = null!;
    }
}
