namespace Pork.Core.Room
{
    class RedRoom
    {
        public static void room ()
        {
            bool leaveRoom = false;
            Console.WriteLine("As you walk in the room, you see that:");
            Console.WriteLine("-> On the wall there are some hieroglyphs.");
            Console.WriteLine("-> There is a book in the middle of the room.");

            while (leaveRoom == false)
            {
                Console.Write("> ");
                string answer = Console.ReadLine();
                switch (answer.ToLower())
                {
                    case "check hieroglyphs":
                        Console.WriteLine(System.IO.File.ReadAllText(@"./Pork.Core/Room/HammerTime.txt"));
                        break;

                    case "check book":
                        Console.WriteLine("You read the title and it says.");
                        Console.WriteLine("-> Thee old tale of MC Hammer");
                        Console.WriteLine("All the books pages are blank.");
                        Console.WriteLine("There is a quill and inkwell on the table.");
                        break;

                    case "chack room":
                        Console.WriteLine("You see that:");
                        Console.WriteLine("-> On the wall there are some hieroglyphs.");
                        Console.WriteLine("-> There is a book in the middle of the room.");
                        break;

                    case "answer book":
                        bool leaveBook = false;
                        while (leaveBook == false)
                        {
                            Console.WriteLine("You prepare the write in the book.");
                            Console.WriteLine("What do you want to write?");
                            Console.Write("-> ");
                            string riddleAnswer = Console.ReadLine();
                            switch (riddleAnswer)
                            {
                                case "":
                                    Console.WriteLine("You can't write nothing.");
                                    break;

                                case "stop hammertime":
                                    Console.WriteLine($"You write {riddleAnswer} in the book.");
                                    Console.WriteLine("The book starts to glow.");
                                    Console.WriteLine("The book opens to a page with a red key on it.");
                                    leaveBook = true;
                                    Inventory.AddItem("Red key");
                                    break;

                                case "leave":
                                    Console.WriteLine("You leave the book.");
                                    leaveBook = true;
                                    break;    

                                default:
                                    Console.WriteLine($"You write {riddleAnswer} in the book.");
                                    Console.WriteLine("The words fades away.");
                                    break;
                            }
                        }
                        break;

                    case "leave":
                        leaveRoom = true;
                        break;

                    default:
                        Core.SudoCommands.sudo(answer, "RedRoom");
                        break;
                }
            }
            Console.WriteLine("You leave the room.");
            Console.WriteLine("--------------------------------------------------------------------------------");

        }
    }
}