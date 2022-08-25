namespace Pork.Core.Room
{
    class PurpleRoom
    {
        public static void room ()
        {
            bool leaveRoom = false;
            Console.WriteLine("As you enter the room, you hear a thundering voice in your head.");
            Console.WriteLine("\"Welcome young traveller\"");
            Console.WriteLine("\"I am the master of this room.\"");
            Console.WriteLine("You look up and see a sphinx.");
            Console.WriteLine("\"Answer my riddle you will be rewarded\"");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\"You walk into a room that contains a match, a kerosene lamp, a candle and a fireplace. What would you light first?\"");
            Console.ResetColor();
            while (leaveRoom == false)
            {
                Console.Write("> ");
                string answer = Console.ReadLine();
                switch (answer.ToLower())
                {
                    case "answer riddle":
                        Console.WriteLine("\"You wish to answer my riddle. Speak up young one and you may be correct.\"");
                        Console.Write("-> ");
                        string riddleAnswer = Console.ReadLine().ToLower();
                        if (riddleAnswer == "the match")
                        {
                            Console.WriteLine("\"You have answered my riddle correctly.\"");
                            Console.WriteLine("\"Here's your reward.\"");
                            Inventory.AddItem("Purple key");
                        }
                        else {
                            Console.WriteLine("\"I can see that you don't have enough brain power to solve my riddle. Try again.\"");
                        }
                        break;

                    case "leave":
                        Console.WriteLine("You leave the room.");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        leaveRoom = true;
                        break;
                    
                    default:
                        SudoCommands.sudo(answer, "PurpleRoom");
                        break;
                }
            }
        }
    }
}