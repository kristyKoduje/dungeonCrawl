using DungeonCrawl.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl.GameCotrols
{
    class Map
    {
        public Item[,] map = new Item[7, 5];

        public Map()
        {
            map[0, 0] = new Wall("stěna", true); map[1, 0] = new Wall("stěna", true); map[2, 0] = new Wall("stěna", true); map[3, 0] = new Wall("stěna", true); map[4, 0] = new Wall("stěna", true); map[5, 0] = new Wall("stěna", true); map[6, 0] = new Wall("stěna", true);
            map[0, 1] = new Wall("stěna", true); map[1, 1] = null; map[2, 1] = new Key("klíč od truhly", true); map[3, 1] = new Wall("stěna", true); map[4, 1] = null; map[5, 1] = new Box("truhla", true); map[6, 1] = new Wall("stěna", true);
            map[0, 2] = new Wall("stěna", true); map[1, 2] = null; map[2, 2] = null; map[3, 2] = new Door("dveře", true); map[4, 2] = null; map[5, 2] = null; map[6, 2] = new Wall("stěna", true);
            map[0, 3] = new Wall("stěna", true); map[1, 3] = null; map[2, 3] = new Box("truhla", true); map[3, 3] = new Wall("stěna", true); map[4, 3] = null; map[5, 3] = null; map[6, 3] = new Wall("stěna", true);
            map[0, 4] = new Wall("stěna", true); map[1, 4] = new Wall("stěna", true); map[2, 4] = new Wall("stěna", true); map[3, 4] = new Wall("stěna", true); map[4, 4] = new Wall("stěna", true); map[5, 4] = new Wall("stěna", true); map[6, 4] = new Wall("stěna", true);
        }
    }
}
