using StructuralPatterns.Bridge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public class AdapterClass
    {


        public AdapterClass()
        {


        }
        public string Color(IBook book)
        {
            string bookColor = book.ToString();
            string[] categories = bookColor.Split('\n')[5].Substring("Categories:".Length).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string category in categories)
            {
                Enum.TryParse(category, out BookCategory bookCategory);
                ConsoleColor color = GetColorForCategory(bookCategory);
                IColor c = new StructuralPatterns.Bridge.Color();    

                if (bookCategory == BookCategory.Adult || bookCategory == BookCategory.YoungAdult || bookCategory == BookCategory.ChildrensBooks)
                {

                    IConsole bc = new BackGroundColor(c);
                    bc.ColorConsole();

                }
                else
                {
                    IConsole fc = new ForeGroundColor(c);
                    fc.ColorConsole();
                }

            }
            return bookColor;
        }

        public ConsoleColor GetColorForCategory(BookCategory category)
        {
            switch (category)
            {
                case BookCategory.NA:
                    return ConsoleColor.Gray;
                case BookCategory.Thriller:
                    return ConsoleColor.Red;
                case BookCategory.Biography:
                    return ConsoleColor.Cyan;
                case BookCategory.SelfHelp:
                    return ConsoleColor.Green;
                case BookCategory.History:
                    return ConsoleColor.Yellow;
                case BookCategory.Holocaust:
                    return ConsoleColor.DarkRed;
                case BookCategory.YoungAdult:
                    return ConsoleColor.Magenta;
                case BookCategory.ChildrensBooks:
                    return ConsoleColor.Blue;
                case BookCategory.Adult:
                    return ConsoleColor.DarkGray;
                default:
                    return ConsoleColor.White;
            }
        }
    }
}
