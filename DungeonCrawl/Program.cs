using DungeonCrawl.GameCotrols;
using DungeonCrawl.Items;
using DungeonCrawl.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class Program
    {
        //je v tom pěknej nepořádek :P
        //chce to poklidit
        enum EPhaseOfGame
        {
            Map,
            Inventary,
            Door,
            Box,
            Fight
        }
        static void Main(string[] args)
        {
            EPhaseOfGame phaseOfGame = EPhaseOfGame.Map;
            Player player = new Player("Pepa", 10, 10, 2, new Point(1, 2), 1, null, null);

            Map map = new Map();

            GameFiller gamefiller = new GameFiller(player, map);

            while (true)
            {
                Console.Clear();
                Console.WriteLine(player.ToString());
                Console.WriteLine();
                Item playerIsStanding = map.map[player.Position.PositionX, player.Position.PositionY];
                ConsoleKeyInfo playerInput;

                switch (phaseOfGame)
                {
                    case EPhaseOfGame.Map:
                        for (int y = 0; y < 5; y++)
                        {
                            for (int x = 0; x < 7; x++)
                                if ((player.Position.PositionX == x) && (player.Position.PositionY == y))
                                    Console.Write('P');
                                else if (map.map[x, y] != null)
                                    Console.Write(map.map[x, y].Symbol);
                                else
                                    Console.Write(" ");
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine((playerIsStanding != null) ? playerIsStanding.Instructions : "Pro pohyb použij šipky. \nPro otevření inventáře zmáčkni ---> I. \nPr interakci s objektem zmáčkni enter.");
                        playerInput = Console.ReadKey(true);
                        if (playerInput.Key == ConsoleKey.RightArrow || playerInput.Key == ConsoleKey.LeftArrow || playerInput.Key == ConsoleKey.UpArrow || playerInput.Key == ConsoleKey.DownArrow)
                            player.Move(playerInput);
                        else if (playerInput.Key == ConsoleKey.I)
                            phaseOfGame = EPhaseOfGame.Inventary;
                        else if (playerInput.Key == ConsoleKey.Enter)
                            if (map.map[player.Position.PositionX, player.Position.PositionY].Symbol == 'D')
                                phaseOfGame = EPhaseOfGame.Door;
                            else if (map.map[player.Position.PositionX, player.Position.PositionY].Symbol == 'T')
                                phaseOfGame = EPhaseOfGame.Box;
                        break;
                    case EPhaseOfGame.Inventary:
                        Console.WriteLine("Toto je tvůj inventář:");
                        int keyToPress = 1;
                        foreach (Item item in player.Inventary)
                            Console.WriteLine("   " + item.ToString() + $" ({keyToPress++})");
                        Console.Write((player.ItemInRightHand != null) ? $"V pravé ruce držíš {player.ItemInRightHand} ({keyToPress++})" : "V pravé ruce nedržíš nic");
                        Console.WriteLine((player.ItemInLeftHand != null) ? $"a v levé držíš { player.ItemInLeftHand} ({keyToPress++})." : " a v levé nedržíš nic.");
                        Console.WriteLine("Vyber, se kterým přemětem chceš něco udělat.");

                        int numberOfItemTochange = TryParse();
                        int counter = 1;
                        foreach (Item item in player.Inventary)
                            if (numberOfItemTochange == counter++)
                            {
                                player.DoSomethingWithUsingItem(item);
                            }
                        if (numberOfItemTochange == counter++)
                        {
                            player.DoSomethingWithUsingItem(player.ItemInRightHand);
                        }
                        else if (numberOfItemTochange == counter)
                            player.DoSomethingWithUsingItem(player.ItemInLeftHand);
                        else
                            Console.WriteLine("Nezadal jsi číslo, které by odpovídalo předmětu");

                        Console.WriteLine("Chceš v úpravě invenáře pokračovat (I), nebo se chceš vrátit na mapu(M)?");
                        playerInput = Console.ReadKey(true);
                        if (playerInput.Key == ConsoleKey.M)
                            phaseOfGame = EPhaseOfGame.Map;
                        break;
                    case EPhaseOfGame.Fight:


                        break;
                    case EPhaseOfGame.Door:


                        break;
                    case EPhaseOfGame.Box:


                        break;
                    default:
                        phaseOfGame = EPhaseOfGame.Map;
                        break;            
                
                
                }










                









            }

            int TryParse()
            {
                while (true)
                {
                    try
                    {
                        int result = int.Parse(Console.ReadLine());
                        return result;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Toto není číslo");
                    }   
                }
            }
        }
    }
}
