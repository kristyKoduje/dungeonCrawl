using DungeonCrawl.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Items
{
    internal class Box : Item
    {
        public Box(string description, bool visibility) 
            : base(description, visibility)
        {
            CanBeAddToInventary = false;
            Instructions = "Toto je truhla. Chceš ji zkusit otevřít? ---> zmáčkni Enter";
            Symbol = 'T';
        }
        public override string ToString()
        {
            return "Truhla";
        }
    }
}
