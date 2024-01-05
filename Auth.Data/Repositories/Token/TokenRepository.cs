using Auth.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Data.Repositories.Token
{
    public class TokenRepository : ITokenRepository
    {
        private readonly DataContext _context;

        public TokenRepository(DataContext context)
        {
            _context = context;
        }
    }
}
