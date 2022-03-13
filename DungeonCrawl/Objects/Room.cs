using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Objects
{
    internal class Room
    {
        private string description;
        private List<Item> itemsInRoom = new List<Item>();
        private Point position;



        public string Description { get => description; set => description = value; }
        public List<Item> ItemsInRoom { get => itemsInRoom; set => itemsInRoom = value; }
        internal Point Position { get => position; set => position = value; }

        public Room(string description, List<Item> itemsInRoom,  Point position)
        {
            this.Description = description;
            this.ItemsInRoom = itemsInRoom;
            this.Position = position;
        }



        public void Search()
        {
            foreach (Item item in ItemsInRoom)
                item.MakeItemVisible();
        }

    }
}
