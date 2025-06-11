using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public interface IBook
    {
        public string ToString();
        public int Id { get; set; }

        public BookCategory Category { get; set; }
        public bool IsItBorrowed { get; set; }
        public DateTime BorrowingDate { get; set; }
        public bool Borrow();
        public bool Return();
    }
}
