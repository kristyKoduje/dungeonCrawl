using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.Objects
{
    internal class Point
    {
        private int positionX;
        private int positionY;

        public Point(int positionX, int positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
        }

        public int PositionX { get => positionX; set => positionX = value; }
        public int PositionY { get => positionY; set => positionY = value; }


    }
    internal abstract class MovingObject
    {
        private double hitPoints;
        private double defence;
        private double attack;

        private int level;

        private Point position;




        public enum EDirectiones
        { 
            right,
            left,
            up, 
            down
        }


        public double HitPoints { get => hitPoints; private set => hitPoints = value; }
        public double Attack { get => attack; private set => attack = value; }
        public double Defence { get => defence; private set => defence = value; }
        public int Level { get => level; private set => level = value; }
        public virtual Point Position { get => position; set => position = value; }


        public MovingObject(double hitPoint, double attack, double defence, Point position, int level)
        {
            this.HitPoints = hitPoint;
            this.Attack = attack;
            this.Defence = defence;
            this.Position = position;
            this.Level = level;
        }


        public virtual void Hit(double oponentAttack, int oponentLevel)
        {
            HitPoints -= (oponentAttack - Defence)*(oponentLevel/Level);
        }

        public virtual void AttackAnOpponent (MovingObject attackedObject)
        {
            attackedObject.Hit(this.Attack, Level);
            if (attackedObject.HitPoints < 0)
                LevelUp();
        }
        public virtual void LevelUp()
        {
            Level++;
        }
    }
}
