using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public class BackGroundColor : IConsole
    {
        IColor color;

        public BackGroundColor(IColor color)
        {
            this.color = color;
        }
        public void ColorConsole()
        {
            Console.ForegroundColor = color.consoleColor;
        }
    }
}
