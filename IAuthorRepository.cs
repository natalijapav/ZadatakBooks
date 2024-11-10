using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace _311
{
    public interface IAuthorRepository
    {
        void AddAuthor(string Authorname, string AuthorBirth);
    }
}
