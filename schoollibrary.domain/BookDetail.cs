using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoollibrary.domain
{
    public class BookDetail
    {
        [Key]
        public int BookId { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
    }
}
