using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Objects.Items
{
    class Drink : Item
    {
        public Drink(string description, bool visibility) 
            : base(description, visibility)
        {
            CanBeAddToInventary = true;
            Symbol = 'L';
            Instructions = "Toto je lektvar. Chceš se na něj podívat? --> Zmáčkni Enter";

        }

        public override string ToString()
        {
            return "Nápoj";
        }
    }
}
