namespace Pork.Core.Room
{
    class BlueRoom
    {
        public static void room ()
        {
            bool leaveRoom = false;
            bool pathFollowed = false;
            Console.WriteLine("As you enter the room you notice a key on a table in the middle of the room.");
            while (leaveRoom == false)
            {
                Console.Write("> ");
                string answer = Console.ReadLine();
                switch (answer.ToLower())
                {
                    case "take key":
                        if (pathFollowed == false)
                        {
                            Console.WriteLine("As you begin to move closer to the key, you bump into a wall.");
                            Console.WriteLine("You feel confused as there are just air all around you.");
                        }
                        else {
                            Console.WriteLine("You take the key.");
                            Inventory.AddItem("Blue key");
                        }
                        break;

                    case "follow stars":
                        Console.WriteLine("You follow the stars and are at the table.");
                        pathFollowed = true;
                        break;

                    case "check room":
                        Console.WriteLine("You see a table in the middle of the room.");
                        Console.WriteLine("As you look down you see some stars along the floor.");
                        break;

                    case "leave":
                        leaveRoom = true;
                        break;
                    
                    default:
                        SudoCommands.sudo(answer, "BlueRoom");
                        break;
                }
            }
            Console.WriteLine("You leave the room.");
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}