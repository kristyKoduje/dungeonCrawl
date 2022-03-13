using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Objects
{
    internal class Enemy : MovingObject
    {
        private string description;

        public string Describtion { get => description; private set => description = value; }
        public Enemy(double hitPoint, double attack, double defence, Point position, int level, string describtion) 
            : base(hitPoint, attack, defence, position, level)
        {
            this.Describtion = description;
        }
        public void Move(EDirectiones direction)
        {
            switch (direction)
            {
                case EDirectiones.right:
                    Position.PositionX++;
                    break;
                case EDirectiones.left:
                    Position.PositionX--;
                    break;
                case EDirectiones.down:
                    Position.PositionY++;
                    break;
                case EDirectiones.up:
                    Position.PositionY--;
                    break;
            }
        }
    }
}
