using StructuralPatterns.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    internal class BasicBook:IBook
    {
        protected IBook book;
        public User User { get; set; }


        public int Id { get => book.Id; set => book.Id = value; }
        public BookCategory Category { get => book.Category; set => book.Category = value; }
        public bool IsItBorrowed { get => book.IsItBorrowed; set => book.IsItBorrowed = value; }
        public DateTime BorrowingDate { get => book.BorrowingDate; set => book.BorrowingDate = value; }
        public BasicBook(IBook Book)
        {
            book = Book;

        }

        public BasicBook()
        {
        }
        public virtual bool Borrow(User user)
        {
            return Borrow();
        }
        public bool Borrow()
        {

            return book.Borrow();
        }

        public bool Return()
        {
            return book.Return();
        }
        public virtual string ToString(User user)
        {
            return book.ToString();
        }
        public override string ToString()
        {
            return book.ToString();
        }
    }
}
