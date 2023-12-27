using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Data.Models
{
    public class Token
    {
        public int TokenId { get; set; }
        public int UserId { get; set; }
        public string? TokenValue { get; set; }
        public int TokenType { get; set; }
        public DateTime TokenExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        // Navigation property to represent the relationship with the User entity
        public User User { get; set; } = new User();
    }
}
