using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public class Category
    {
        public Category()
        {
            Books = new List<Book>();
        }
        public string Id { get; set; }
        public string Title { get; set; }
        public List<Book> Books { get; set; }
    }
}
