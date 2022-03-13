using DungeonCrawl.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Items
{
    internal class Puzzle : Item
    {
        public Puzzle(string description, bool visibility) 
            : base(description, visibility)
        {
            CanBeAddToInventary = false;
            Instructions = "Toto je hádanka. Chceš si ji přečíst? ---> zmáčkni Enter";
            Symbol = 'H';
        }
        public override string ToString()
        {
            return "Hádanka";
        }
    }
}
