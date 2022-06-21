using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoollibrary.domain
{
    public class Book
    {
        public int BookId { get; set; }
        public decimal Serial { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public bool IsDeleted { get; set; }
    }
}
