using StructuralPatterns.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    public class Book : IBook
    {

        public static int IdCode = 0;
        private  IBaseBook baseBook { get; set; }
        public int Id { get; set; }


        public string Author { get { return baseBook.Author; } set { baseBook.Author = value; } }

        public BookCategory Category { get { return baseBook.Category; } set { baseBook.Category = value; } }
        public bool IsItBorrowed { get; set; }
        public DateTime BorrowingDate { get; set; }
        public string Name { get { return baseBook.Name; } set { baseBook.Name = value; } }
        public Book(string name, string author, BookCategory category)
        {
            Id = ++IdCode;
            baseBook = BookManager.getBook(name, author, category);
            IsItBorrowed = false;



        }
        public Book()
        {
            Id = ++IdCode;
        }
        public override string ToString()
        {
            return $"Name is:{Name}\nAuthor is:{Author}\nId is:{Id}\nIsItBorrowed is:{IsItBorrowed}\nBorrowingDate is:{BorrowingDate}\nCategories:{BookCategory()}";
        }
        public string BookCategory()
        {
            string f = "";

            foreach (BookCategory category in Enum.GetValues(typeof(BookCategory)))
            {
                if (this.Category.HasFlag(category))
                {
                    f += $"{category},";
                }
            }
            return f;

        }

        public bool Borrow()
        {
            if (IsItBorrowed)
                return false;
            IsItBorrowed = true;
            Console.WriteLine($"the book{baseBook.Name} was borrowed successfully");
            BorrowingDate = DateTime.Now;
            return true;
        }


        public bool Return()
        {
            if (!IsItBorrowed)
                return false;
            Console.WriteLine($"the book{baseBook.Name} was returned successfully");
            IsItBorrowed = false;
            return true;
        }
    }
}
