using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public interface IColor
    {
        public ConsoleColor consoleColor { get; set; }
        public void color(ConsoleColor color);
    }
}
