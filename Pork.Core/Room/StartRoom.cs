namespace Pork.Core.Room
{
    class StartRoom
    {
        public static void room ()
        {
            bool nextroom = false;
            bool unlocked = false;
            Console.WriteLine("You wake up in a dimly lit room, not knowing how you got here. With a door in front of you.");
            while (nextroom == false)
            {
                Console.Write("> ");
                string answer = Console.ReadLine();


                switch (answer.ToLower())
                {

                    case "open door":
                        if (unlocked == false)
                        {
                            Console.WriteLine("The door is locked.");
                        } else {
                            Console.WriteLine("You open the door and go to the next room.");
                            nextroom = true;
                        }
                        break;

                    case "check door":
                        Console.WriteLine("You see a padlock with 3 inputs");
                        break;

                    // Padlock numbers are 4 1 9
                    case "check padlock":
                        bool leave = false;
                        while (leave == false)
                        {
                            Console.WriteLine("You see a padlock with 3 inputs");
                            Console.Write("-> ");
                            string padlockanswer = Console.ReadLine();
                            switch (padlockanswer.ToLower())
                            {
                                case "leave":
                                    leave = true;
                                    break;
                                
                                case "input numbers":
                                    Console.Write("> ");
                                    int number1 = int.Parse(Console.ReadLine());
                                    Console.Write("> ");
                                    int number2 = int.Parse(Console.ReadLine());
                                    Console.Write("> ");
                                    int number3 = int.Parse(Console.ReadLine());
                                    if (number1 == 4 && number2 == 1 && number3 == 9)
                                    {
                                        Console.WriteLine("The padlock opens and you can now open the door.");
                                        Inventory.AddItem("Padlock");
                                        unlocked = true;
                                        leave = true;
                                    } else {
                                        Console.WriteLine("The padlock doesn't open.");
                                    }
                                    break;

                                default:
                                    Console.WriteLine("I don't understand what you are saying.");
                                    break;
                            }
                        }
                        break;

                    case "check room":
                        Console.WriteLine("You faintly see some text above the door that reads.");
                        Console.WriteLine("\"FOUR those who find them selves in this ONE room.");
                        Console.WriteLine("many have left, but only NINE survived.\"");
                        break;

                    default:
                        Core.SudoCommands.sudo(answer, "StartRoom");
                        break;
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Core.Room.CenterRoom.room(true);
        }
    }
}