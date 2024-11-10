using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _311
{
    
        public class Book
        {
            public int Id { get; set; }
            public string BookTitle { get; set; }
            public int BookYear { get; set; }
            public string BookGenre { get; set; }

            public int AuthorsId { get; set; }
            public Author Authors { get; set; }
            

        }
    
}
