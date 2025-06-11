using StructuralPatterns.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    internal class LibraryOnlyBook:BasicBook
    {
        public LibraryOnlyBook(IBook book) : base(book)
        {


        }
        public override bool Borrow(User user)
        {
            if (user.IsPremium)
            {
                Console.WriteLine("This book can only be read in the library,it can't be borrowed");
                return true;
            }
            Console.WriteLine("you can not read or borrow this book!");
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
