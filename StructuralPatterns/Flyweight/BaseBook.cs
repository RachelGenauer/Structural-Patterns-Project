using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight
{
    internal class BaseBook:IBaseBook
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public BookCategory Category { get; set; }
        public BaseBook(string name, string author, BookCategory category)
        {
            Name = name;
            Author = author;
            Category = category;
        }

    }
}
