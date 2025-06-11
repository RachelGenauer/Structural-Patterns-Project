using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight
{
    internal interface IBaseBook
    {
        string Name { get; set; }
        public string Author { get; set; }
        public BookCategory Category { get; set; }
    }
}
