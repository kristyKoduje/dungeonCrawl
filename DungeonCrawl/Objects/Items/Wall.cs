using DungeonCrawl.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Items
{
    internal class Wall : Item
    {
        public Wall(string description, bool visibility) 
            : base(description, visibility)
        {
            CanBeAddToInventary = false;
            Symbol = 'S';
            Instructions = "Jak ses sem dostal? Sem by tě to vůbec nemělo pustit!";
        }
    }
}
