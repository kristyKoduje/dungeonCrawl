using DungeonCrawl.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Items
{
    internal class Shield : Item
    {
        public Shield(string description, bool visibility) 
            : base(description, visibility)
        {
            CanBeAddToInventary = true;
            Instructions = "Toto je štít. Chceš se na něj podívat? --> Zmáčkni Enter";
            Symbol = 'Š';
        }
        public override string ToString()
        {
            return "Štít";
        }
    }
}
