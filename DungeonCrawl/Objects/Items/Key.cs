using DungeonCrawl.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    internal class Key : Item
    {
        public Key(string description, bool visibility) 
            : base(description, visibility)
        {
            CanBeAddToInventary = true;
            Instructions = "Toto je klíč. Chceš ho dát do inventáře? ---> zmáčkni Enter";
            Symbol = 'K';
        }
        public override string ToString()
        {
            return "Klíč";
        }
    }
}
