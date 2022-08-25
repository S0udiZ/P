namespace Pork.Core.Room
{
    class GreenRoom
    {
        public static void room ()
        {
            bool leaveRoom = false;
            string fool = "south";
            string knight = "south";
            string king = "south";
            string preist = "south";
            Console.WriteLine("You walk in and see 4 stues in the room. All facing south.");
            Console.WriteLine("-> One of a fool");
            Console.WriteLine("-> One of a knight");
            Console.WriteLine("-> One of a king");
            Console.WriteLine("-> One of a preist");
            Console.WriteLine("You see a lever in the middle of the room.");
            while (leaveRoom == false)
            {
                Console.Write("> ");
                string answer = Console.ReadLine().ToLower();
                switch (answer)
                {
                    case "check room":
                        Console.WriteLine("You see 4 stues in the room. All facing south.");
                        Console.WriteLine("-> One of a fool");
                        Console.WriteLine("-> One of a knight");
                        Console.WriteLine("-> One of a king");
                        Console.WriteLine("-> One of a priest");
                        Console.WriteLine("You see a lever in the middle of the room.");
                        Console.WriteLine("You also see some text on the walls, that reads:");
                        Console.WriteLine(System.IO.File.ReadAllText(@".\Pork.Core\Room\GreenRoomRiddle.txt"));
                        break;

                    case "rotate fool south":
                        Console.WriteLine("You rotate the fool south.");
                        fool = "south";
                        break;

                    case "rotate fool north":
                        Console.WriteLine("You rotate the fool north.");
                        fool = "north";
                        break;

                    case "rotate fool east":
                        Console.WriteLine("You rotate the fool east.");
                        fool = "east";
                        break;

                    case "rotate fool west":
                        Console.WriteLine("You rotate the fool south.");
                        fool = "south";
                        break;
                    
                    case "rotate knight south":
                        Console.WriteLine("You rotate the knight south.");
                        knight = "south";
                        break;

                    case "rotate knight north":
                        Console.WriteLine("You rotate the knight north.");
                        knight = "north";
                        break;

                    case "rotate knight east":
                        Console.WriteLine("You rotate the knight east.");
                        knight = "east";
                        break;

                    case "rotate knight west":
                        Console.WriteLine("You rotate the knight south.");
                        knight = "south";
                        break;
                        
                    case "rotate king south":
                        Console.WriteLine("You rotate the king south.");
                        king = "south";
                        break;

                    case "rotate king north":
                        Console.WriteLine("You rotate the king north.");
                        king = "north";
                        break;

                    case "rotate king east":
                        Console.WriteLine("You rotate the king east.");
                        king = "east";
                        break;

                    case "rotate king west":
                        Console.WriteLine("You rotate the king south.");
                        king = "south";
                        break;
                    
                    case "rotate preist south":
                        Console.WriteLine("You rotate the preist south.");
                        preist = "south";
                        break;

                    case "rotate preist north":
                        Console.WriteLine("You rotate the preist north.");
                        preist = "north";
                        break;

                    case "rotate preist east":
                        Console.WriteLine("You rotate the preist east.");
                        preist = "east";
                        break;

                    case "rotate preist west":
                        Console.WriteLine("You rotate the preist south.");
                        preist = "west";
                        break;

                    case "pull lever":
                        if (fool == "south" && knight == "north" && king == "north" && preist == "west")
                        {
                            Console.WriteLine("You pull the lever and the tile beneath you starts to move.");
                            Console.WriteLine("You look down and see the tile open and a key lies inside.");
                            Console.WriteLine("You pick up the key and put it in your inventory.");
                            Inventory.AddItem("Green key");
                        }
                        else {
                            Console.WriteLine("You pull the lever and all the statues rotates back to their original position.");
                            fool = "south";
                            knight = "south";
                            king = "south";
                            preist = "south";
                        }
                        break;

                    case "leave":
                        Console.WriteLine("You leave the room.");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        leaveRoom = true;
                        break;

                    default:
                        SudoCommands.sudo(answer, "GreenRoom");
                        break;
                }
            }
        }
    }
}