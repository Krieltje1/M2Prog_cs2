using System;
using System.Collections.Generic;

namespace _05_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();
            personeelOpNummer.Add(382942, "Jim");
            personeelOpNummer.Add(789432, "Tim");

            Console.WriteLine(personeelOpNummer[382942]);
            Console.WriteLine(personeelOpNummer[789432]);

            foreach (KeyValuePair<int, string> medewerker in personeelOpNummer)
            {
                Console.WriteLine($"{medewerker.Key}: {medewerker.Value}");
            }

            foreach (int key in personeelOpNummer.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (string value in personeelOpNummer.Values)
            {
                Console.WriteLine(value);
            }

            // Room system
            Dictionary<string, Room> rooms = new Dictionary<string, Room>();

            Room start = new Room(0, 0, new string[]
            {
                "#####",
                "#...#",
                "#...#",
                "#...#",
                "#####"
            });

            Room hallway = new Room(0, 1, new string[]
            {
                "#####",
                "#...#",
                "#.A.#",
                "#...#",
                "#####"
            });

            Room end = new Room(0, 2, new string[]
            {
                "#####",
                "#...#",
                "#.T.#",
                "#...#",
                "#####"
            });

            rooms.Add(start.GetRoomLocationKey(), start);
            rooms.Add(hallway.GetRoomLocationKey(), hallway);
            rooms.Add(end.GetRoomLocationKey(), end);

            ShowRoom(rooms, 0, 0);
            ShowRoom(rooms, 0, 1);
            ShowRoom(rooms, 0, 2);
            ShowRoom(rooms, 1, 0);
        }

        static void ShowRoom(Dictionary<string, Room> rooms, int x, int y)
        {
            string key = $"{x},{y}";

            if (!rooms.ContainsKey(key))
            {
                Console.WriteLine("Room not found!");
                return;
            }

            Room room = rooms[key];
            Console.WriteLine($"You're in room {x},{y}:");

            foreach (string row in room.level)
            {
                Console.WriteLine(row);
            }

            bool hasRoom = rooms.ContainsKey($"{x},{y}");

            if(hasRoom)
            {
                Console.WriteLine("There is a room here.");
            }
            else
            {
                Console.WriteLine("There is no room here.");
                
            }
        
    }

    class Room
    {
        internal int x, y;
        internal string[] level;

        internal Room(int x, int y, string[] level)
        {
            this.x = x;
            this.y = y;
            this.level = level;
        }

        internal string GetRoomLocationKey()
        {
            return $"{x},{y}";
        }
    }
    }
}
