using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoollibrary.service.Utils
{
    internal class Serial
    {
        public decimal GetNewSerialNumber()
        {
            Thread.Sleep(10);
            var number = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
            return 1;
        }
    }
}
