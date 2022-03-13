using DungeonCrawl.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Items
{
    internal class Sword : Item
    {
        public Sword(string description, bool visibility) 
            : base(description, visibility)
        {
            CanBeAddToInventary = true;
            Symbol = 'M';
            Instructions = "Toto je meč. Chceš se na něj podívat? --> Zmáčkni Enter?";
        }
        public override string ToString()
        {
            return "Meč";
        }
    }
}
