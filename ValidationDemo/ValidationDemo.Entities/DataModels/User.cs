using System;
using System.Collections.Generic;

namespace ValidationDemo.Entities.DataModels
{
    public partial class User
    {
        public long UserId { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public string Email { get; set; } = null!;

        public virtual Role Role { get; set; } = null!;
    }
}
