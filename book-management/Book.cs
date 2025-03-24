using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management
{
    internal class Book
    {
        public int Id { get; set; }
        public string Label { get; set; }

        public string Author { get; set; }
        public int Sold { get; set; }
    }
}
