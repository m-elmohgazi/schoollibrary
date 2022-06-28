using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoollibrary.domain
{
    public class Unit
    {
        public int UnitId { get; set; }
        public decimal Serial { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BookId { get; set; }
    }
}
