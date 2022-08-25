namespace Pork.Core.Room
{
    class YellowRoom
    {
        public static void room ()
        {
            bool leaveRoom = false;
            bool mirrorChecked = false;
            Console.WriteLine("As you enter the room, you see that there insen't anything but a large mirror in the room.");
            while (leaveRoom == false)
            {
                Console.Write("> ");
                string answer = Console.ReadLine();
                switch (answer.ToLower())
                {
                    case "check mirror":
                        Console.WriteLine("As you look closer in the mirror, you see in the reflection thet there is a table infront of you with a key on it.");
                        mirrorChecked = true;
                        break;

                    case "check room":
                        Console.WriteLine("You see a large mirror in the room.");
                        break;

                    case "take key":
                        if (mirrorChecked == true)
                        {
                            Console.WriteLine("You take the key and put it in your pocket.");
                            Inventory.AddItem("Yellow key");
                        }
                        else
                        {
                            Console.WriteLine("There isen't a key in the room.");
                        }
                        break;

                    case "leave":
                        Console.WriteLine("You leave the room.");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        leaveRoom = true;
                        break;

                    default:
                        SudoCommands.sudo(answer, "YellowRoom");
                        break;
                }
            }
        }
    }
}