using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Proxy
{
    internal class User
    {
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public User(string name, bool isPremium)
        {
            Name = name;
            IsPremium = isPremium;
        }
    }
}
