using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite
{
    internal class BooksInCategory
    {
        BookCategory Category { get; set; }
        List<BooksInCategory> subCategories = new List<BooksInCategory>();
        List<IBook> books = new List<IBook>();
        public BooksInCategory()
        {

        }
        public BooksInCategory(BookCategory _category, List<BooksInCategory> _subCategories)
        {
            this.Category = _category;
            subCategories = _subCategories;
        }


        public bool AddBook(IBook book)
        {
            if (Category == book.Category)
            {
                books.Add(book);
               
                return true;
            }
            if (subCategories == null)
            {
                return false;
            }
            foreach (var cat in subCategories)
            {
                if (book.Category.HasFlag(cat.Category))
                {
                    return cat.AddBook(book);
                }
            }
            return false;
        }

        public IBook Search(int id)
        {
          
                IBook b = books.FirstOrDefault(x => x.Id == id);
                if (b != null)
                    return b;
                if (subCategories != null)
                {
                    foreach (var cat in subCategories)
                    {
                        b = cat.Search(id);
                        if (b != null)
                            return b;
                    }
                }
                return null;
            
        }

        public string ToString(int id)
        {
            IBook book = Search(id);
            if (book != null)
                return book.ToString();
            return null;
        }
        public bool Borrow(int id)
        {
            IBook book = Search(id);
            if (book != null)
                return book.Borrow();
            return false;
        }
        public bool Return(int id)
        {
            IBook book = Search(id);
            if (book != null)
                return book.Return();
            return false;
        }




    }
}
