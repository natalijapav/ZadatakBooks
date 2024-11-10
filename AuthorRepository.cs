using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace _311
{
    public class AuthorRepository
    {
        private readonly LibraryContext _context;

        public AuthorRepository()
        {
            _context = new LibraryContext();
        }
        public async Task AddAuthorAsync(Author author)
        {
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
        }
    }
}
