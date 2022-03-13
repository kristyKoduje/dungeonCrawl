using DungeonCrawl.Items;
using DungeonCrawl.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.GameCotrols
{
    class GameFiller
    {
        public GameFiller (Player player, Map map)
        {
            player.addToMovableArea(new Point(1, 1));
            player.addToMovableArea(new Point(1, 2));
            player.addToMovableArea(new Point(2, 1));
            player.addToMovableArea(new Point(2, 2));
            player.addToMovableArea(new Point(3, 2));
            player.addToMovableArea(new Point(1, 3));
            player.addToMovableArea(new Point(2, 3));
            player.addToMovableArea(new Point(2, 3));

            player.PutOn(new Sword("Dlouhý meč", true), Player.EWearablePlaces.leftHand);
            player.PutInInventary(new Key("Zlatý klíč", true));
        }
    }
}
