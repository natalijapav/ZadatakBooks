using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _311
{
    public class Author
    {
        public int Id { get; set; }   
        public string AuthorName { get; set; }
        public DateTime AuthorBirth { get; set; }

        public ICollection<Book> Knjige { get; set; } = new List<Book>();
    }



}
