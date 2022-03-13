using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    internal abstract class Item
    {
        private string description;
        private string instructions;
        private bool visibility;
        private bool canBeAddToInventary;
        private char symbol;
        public string Description { get => description; internal set => description = value; }
        public bool Visibility { get => visibility; internal set => visibility = value; }
        public bool CanBeAddToInventary { get => canBeAddToInventary; internal set => canBeAddToInventary = value; }
        public char Symbol { get => symbol; internal set => symbol = value; }
        public string Instructions { get => instructions; internal set => instructions = value; }

        protected Item(string description, bool visibility)
        {
            Description = description;
            Visibility = visibility;
        }

        public void MakeItemVisible()
        {
            Visibility = true;
        }

    }
}
