using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoollibrary.domain
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public decimal Serial { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Content { get; set; }
        public int UnitId { get; set; }
    }
}
