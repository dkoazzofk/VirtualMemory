using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    public class Page
    {
        public string[] page { get; set; } = new string[512];
        public int rw { get; set; }
        public int number { get; set; }
        public DateTime time { get; set; }
        public Page(string[] Page)
        {
            page = Page;
        }
        public void Read()
        {
        }
    }
}
