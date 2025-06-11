using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Flyweight
{
    internal class BookManager
    {
        static List<IBaseBook> books = new List<IBaseBook>();
        public BookManager()
        {

        }
        static public IBaseBook getBook(string name, string author, BookCategory category)
        {
            IBaseBook book = books.FirstOrDefault(book => book.Name == name && book.Author == author && book.Category == category);
            if (book == null)
            {
                book = new BaseBook(name, author, category);
                books.Add(book);
            }
            return book;
        }
    }
}
