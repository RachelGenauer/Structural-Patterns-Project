using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    [Flags]
    public enum BookCategory
    {
        NA = 0,              //00000000// לא הוגדר
        Thriller = 1,        //00000001// מותחן
        Biography = 2,       //00000010// בביאוגרפיה
        SelfHelp = 4,        //00000100// עזרה עצמית
        History = 8,         //00001000// היסטוריה
        Holocaust = 16,      //00010000// שואה
        YoungAdult = 32,     //00100000// נוער
        ChildrensBooks = 64, //01000000// ילדים
        Adult = 128,         //10000000//מבוגרים
    }
}
