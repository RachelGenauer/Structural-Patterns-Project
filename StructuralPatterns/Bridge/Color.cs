using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public class Color:IColor
    {
        public ConsoleColor consoleColor { get; set; }


        public Color()
        {
          
        }
        public void color(ConsoleColor consoleColor)
        {
            this.consoleColor = consoleColor;
        }

    }
}
