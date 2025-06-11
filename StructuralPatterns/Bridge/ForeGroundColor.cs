using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public class ForeGroundColor:IConsole
    {
        IColor color;

        public ForeGroundColor(IColor color)
        {
            this.color = color;
        }
        public void ColorConsole()
        {
            Console.ForegroundColor = color.consoleColor;
        }
    }
}
