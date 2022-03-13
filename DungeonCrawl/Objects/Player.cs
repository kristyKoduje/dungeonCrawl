using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Objects
{
    internal class Player : MovingObject
    {
        public enum EWearablePlaces
        {
            leftHand,
            rightHand
        }

        private string name;

        private List<Item> inventary = new List<Item>();
        private List<Point> moveableArea = new List<Point>();

        private Item itemInLeftHand;
        private Item itemInRightHand;

        public string Name { get => name; private set => name = value; }
        public List<Item> Inventary { get => inventary; private set => inventary = value; }
        public Item ItemInLeftHand { get => itemInLeftHand; private set => itemInLeftHand = value; }
        public Item ItemInRightHand { get => itemInRightHand; private set => itemInRightHand = value; }
        public override Point Position 
        { 
            get => base.Position; 
            set 
            {
                foreach (Point point in moveableArea)
                    if (point.PositionX == value.PositionX && point.PositionY == value.PositionY)
                        base.Position = value; 
            } 
        }

        public Player(string name, double hitPoint, double defence, double attack, Point position, int level, Item leftHand, Item rightHand)
            : base(hitPoint, attack, defence, position, level)
        {
            this.Name = name;
            this.ItemInLeftHand = leftHand;
            this.itemInRightHand = rightHand;
            addToMovableArea(position);
            Position = position;

        }

        public void addToMovableArea(Point point)
        {
            moveableArea.Add(point);
        }
        public void DoSomethingWithUsingItem(Item item)
        {
            Console.WriteLine("Co chceš udělat?");
            Console.WriteLine("Zahodit (Z) - pozor předmět úplně ztratíš");
            if (item == itemInLeftHand || item == itemInRightHand)
            {
                Console.WriteLine("Dát do inventáře (I)");
                ConsoleKeyInfo playerInput = Console.ReadKey(true);
                switch (playerInput.Key)
                {
                    case ConsoleKey.I:
                        PutInInventary(item);
                        if (item == itemInLeftHand)
                            TakeOff(item, EWearablePlaces.leftHand);
                        else
                            TakeOff(item, EWearablePlaces.rightHand);
                        break;
                    case ConsoleKey.Z:
                        if (item == itemInLeftHand)
                            TakeOff(item, EWearablePlaces.leftHand);
                        else
                            TakeOff(item, EWearablePlaces.rightHand);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Dát do levé ruky (L)");
                Console.WriteLine("Dát do levé ruky (P)");
                ConsoleKeyInfo playerInput = Console.ReadKey(true);
                switch (playerInput.Key)
                {
                    case ConsoleKey.L:
                        PutOn(item, EWearablePlaces.leftHand);
                        TakeFromInventary(item);
                        break;
                    case ConsoleKey.P:
                        PutOn(item, EWearablePlaces.rightHand);
                        TakeFromInventary(item);
                        break;
                    case ConsoleKey.Z:
                        TakeFromInventary(item);
                        break;
                }
            }

            
        
        }
        public void PutInInventary(Item item)

        {
            if (item.CanBeAddToInventary)
                Inventary.Add(item);
        }
        public void TakeFromInventary(Item item)
        {
            Inventary.Remove(item);
        }
        public void PutOn (Item item, EWearablePlaces wearablePlace)
        {
            switch(wearablePlace)
            {
                case EWearablePlaces.leftHand:
                    if (ItemInLeftHand != null)
                        TakeOff(item, wearablePlace);
                    ItemInLeftHand = item;
                    break;
                case EWearablePlaces.rightHand:
                    if (ItemInRightHand != null)
                        TakeOff(item, wearablePlace);
                    ItemInRightHand = item;
                    break;
            }
        }
        public void TakeOff(Item item, EWearablePlaces wearablePlace)
        {
            switch (wearablePlace)
            {
                case EWearablePlaces.leftHand:
                    if (ItemInLeftHand != null)
                    {
                        Inventary.Add(item);
                        ItemInLeftHand = null;
                    }
                    break;
                case EWearablePlaces.rightHand:
                    if (ItemInRightHand != null)
                    {
                        Inventary.Add(item);
                        ItemInRightHand = null;
                    }
                    break;
            }
        }
        public void Move(ConsoleKeyInfo direction)
        {
            switch (direction.Key)
            {
                case ConsoleKey.RightArrow:
                    Position = new Point (Position.PositionX+1, Position.PositionY);
                    break;
                case ConsoleKey.LeftArrow:
                    Position = new Point (Position.PositionX-1, Position.PositionY);
                    break;
                case ConsoleKey.DownArrow:
                    Position = new Point (Position.PositionX, Position.PositionY+1);
                    break;
                case ConsoleKey.UpArrow:
                    Position = new Point (Position.PositionX, Position.PositionY-1);
                    break;
            }
        }
        public override string ToString()
        {
            return $"Jméno hráče: {Name}. Počet životů: {HitPoints}." + ((inventary.Count > 0) ? $"V inventáři máš {string.Join(", ", inventary)}." : "V inventáři nic nemáš.");
        }
    }
}
