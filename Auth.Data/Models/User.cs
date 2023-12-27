using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[32];
        public int Role { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<Token> Tokens { get; set; } = new List<Token>();
    }
}
