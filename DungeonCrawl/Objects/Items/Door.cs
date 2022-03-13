using DungeonCrawl.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Items
{
    internal class Door : Item
    {
        private bool isOpen;
        public bool IsOpen { get => isOpen; private set => isOpen = value; }



        public Door(string description, bool visibility) 
            : base(description, visibility)
        {
            CanBeAddToInventary = false;
            isOpen = false;
            Instructions = "Pro otevření dveří potřebuješ klíč. Chceš zkusit dveře otevřít? ---> zmáčni Enter";
            Symbol = 'D';
        }


        public override string ToString()
        {
            return "Dveře";
        }
    }
}
