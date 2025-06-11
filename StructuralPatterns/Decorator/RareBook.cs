using StructuralPatterns.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    internal class RareBook:BasicBook
    {
        public RareBook(IBook book) : base(book)
        {


        }
        public override bool Borrow(User user)
        {
            if (user.IsPremium)
                return book.Borrow();

            Console.WriteLine("the book can not be borrowed, you are not a premium member");
            return false;
        }
        public override string ToString(User user)
        {
            if (user.IsPremium)
            {
                return base.ToString(user);
            }
            else
            {
                return "this is a book that can only be read in the library and you are not premium";
            }
        }


    }
}
