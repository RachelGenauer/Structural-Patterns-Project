using StructuralPatterns.Adapter;
using StructuralPatterns.Composite;
using StructuralPatterns.Decorator;
using StructuralPatterns.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace StructuralPatterns.Facade
    {
        internal class FacadeClass
        {

            public static List<User> users = new List<User>();
            public  BooksInCategory allCategories = new BooksInCategory();
            public FacadeClass()
            {
                BooksInCategory YoungAdultSelfHelpCat = new BooksInCategory(BookCategory.YoungAdult | BookCategory.SelfHelp, null);
                BooksInCategory YoungAdultBiographyCat = new BooksInCategory(BookCategory.YoungAdult | BookCategory.Biography, null);
                BooksInCategory YoungAdultThrillerCat = new BooksInCategory(BookCategory.YoungAdult | BookCategory.Thriller, null);
                BooksInCategory AdultSelfHelpCat = new BooksInCategory(BookCategory.Adult | BookCategory.SelfHelp, null);
                BooksInCategory AdultHolocaustCat = new BooksInCategory(BookCategory.Adult | BookCategory.Holocaust, null);
                BooksInCategory AdultBiographyCat = new BooksInCategory(BookCategory.Adult | BookCategory.Biography, null);
                BooksInCategory AdultThrillerCat = new BooksInCategory(BookCategory.Adult | BookCategory.Thriller, null);
                BooksInCategory ChildrensBooksThrillerCat = new BooksInCategory(BookCategory.ChildrensBooks | BookCategory.Thriller, null);
                BooksInCategory ChildrensBooksSelfHelpCat = new BooksInCategory(BookCategory.ChildrensBooks | BookCategory.SelfHelp, null);
                BooksInCategory YoungAdultCat = new BooksInCategory(BookCategory.YoungAdult, new List<BooksInCategory>() { YoungAdultSelfHelpCat, YoungAdultThrillerCat });
                BooksInCategory AdultCat = new BooksInCategory(BookCategory.Adult, new List<BooksInCategory>() { AdultSelfHelpCat, AdultThrillerCat, AdultBiographyCat, AdultHolocaustCat });
                BooksInCategory ChidrensBooksCat = new BooksInCategory(BookCategory.ChildrensBooks, new List<BooksInCategory> { ChildrensBooksThrillerCat, ChildrensBooksSelfHelpCat });
                allCategories = new BooksInCategory(BookCategory.NA, new List<BooksInCategory>() { YoungAdultCat, AdultCat, ChidrensBooksCat });
                IBook b0 = new Book("Those were the days", "Esther Cherrick", BookCategory.YoungAdult | BookCategory.Thriller);

                IBook b1 = new Book("Making a kiddush Hashem", "Faigy Paretzky", BookCategory.ChildrensBooks | BookCategory.Thriller);
                IBook b2 = new Book("My Memories", "Dasi O.", BookCategory.Adult | BookCategory.Biography);
                IBook b3 = new Book("Gate Of Heaven", "Moria Lustig", BookCategory.Adult | BookCategory.History);
                IBook b4 = new Book("About Marriage", "Sari", BookCategory.Adult | BookCategory.SelfHelp);
                IBook b5 = new Book("Between Engagement To Marriage", "Rachel", BookCategory.Adult | BookCategory.SelfHelp);
                User user1 = new User("Moria", true);
                User user2 = new User("Dasi", false);
                User user3 = new User("Esther", true);
                User user4 = new User("Sari", false);
            IBook LibraryOnlyBook1 = new LibraryOnlyBook(b0);
            IBook LibraryOnlyBook2 = new LibraryOnlyBook(b1);
            IBook RareBook1 = new RareBook(new Book("Mehalalel", "Maya Keinan", BookCategory.Thriller | BookCategory.YoungAdult));
            IBook RareBook2 = new RareBook(new Book("Mi Keamcha Yisroel", "M.E.", BookCategory.ChildrensBooks | BookCategory.SelfHelp));


            allCategories.AddBook(b2);
            allCategories.AddBook(b3);
            allCategories.AddBook(b4);
            allCategories.AddBook(b5);
            allCategories.AddBook(LibraryOnlyBook1);
            allCategories.AddBook(LibraryOnlyBook2);
            allCategories.AddBook(RareBook1);
            allCategories.AddBook(RareBook2);
    
                users.Add(user1);
                users.Add(user2);
                users.Add(user3);
                users.Add(user4);

            }
            public void BorrowAndReturn(User user)
            {

                Console.Write("To borrow press 1\nTo return press 2\nand if you with access permission- press 3 to display the book\n press 4 to display with color:");
                string x = Console.ReadLine();
                switch (x)
                {
                    case "1":
                        Borrow(user);
                        break;
                    case "2":
                        Return();
                        break;
                    case "3":
                        DisplayBook(user);
                        break;
                    case "4":
                        ColorDisplay();
                        break;
                    default:
                        Console.WriteLine("mistake");
                        break;
                }
            }
            public void Return()
            {

                Console.Write("please enter the id of the book:");
                string name = Console.ReadLine();

                int bookId;

                bool success = int.TryParse(name, out bookId);

                while (!success)
                {
                    success = int.TryParse(name, out bookId);
                }

                IBook book = allCategories.Search(bookId);
                if (book == null)
                    Console.WriteLine("the book does not exist");
                else

                    book.Return();

            }
            public void ColorDisplay()
        {
                Console.WriteLine("please enter the id of the book you want its details:");
                int bookId = int.Parse(Console.ReadLine());
                IBook book = allCategories.Search(bookId);
                if (book == null)
                    Console.WriteLine("the book does not exist");
                else
                {
                    AdapterClass adapter = new AdapterClass();
                    Console.WriteLine(adapter.Color(book));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
            public void DisplayBook(User user)
            {
                Console.WriteLine("please enter the id of the book you want its details:");
                string name = Console.ReadLine();
                int bookId = int.Parse(name);
                IBook book = allCategories.Search(bookId);
                if (book == null)
                    Console.WriteLine("the book does not exist");
                else
                if (book is LibraryOnlyBook)
                    ((LibraryOnlyBook)book).ToString(user);
                else if (book is RareBook)
                    ((RareBook)book).ToString(user);

                else
                {
                    Console.WriteLine(book.ToString());

                }
            }


            public void Borrow(User user)
            {

                Console.WriteLine("please enter the id of the book:");


                int bookId = int.Parse(Console.ReadLine());
                IBook book = allCategories.Search(bookId);
                if (book == null)
                    Console.WriteLine("the book does not exist");
                else if (book is LibraryOnlyBook)
                    ((LibraryOnlyBook)book).Borrow(user);
                else if (book is RareBook)
                    ((RareBook)book).Borrow(user);
                else book.Borrow();
            }


            public void LogIn()
            {
                Console.WriteLine("please enter your name:");
                string name = Console.ReadLine();
                User user = users.FirstOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (user == null)
                {
                    Console.Write("Sorry,You are not registered if you want to sign up press 1, if you want to exit press 0:");
                    string bookId =Console.ReadLine();
                    if (bookId == "1")
                    {
                    Console.WriteLine("are you a premium member?(y/n)");
                    bool isPremium = bool.Parse(Console.ReadLine());
                     user = new User(name, isPremium);
                        SignIn(user);

                    }



                }

                else BorrowAndReturn(user);

            }
            public void SignIn(User user)
            {
                users.Add(user);
            }
        }
    }



