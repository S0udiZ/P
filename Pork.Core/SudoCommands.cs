namespace Pork.Core
{
    class SudoCommands
    {
        public static void sudo(string command, string room)
        {
            switch (command.ToLower())
            {
                case "clear game screen":
                    Console.Clear();
                    break;
                
                case "inventory":
                    Inventory.ListItems();
                    break;

                case "menu":
                    Core.Menu.menu();
                    break;

                case "help":
                    Console.WriteLine(System.IO.File.ReadAllText(@".\Help.txt"));
                    break;

                case "map":
                    Console.WriteLine(System.IO.File.ReadAllText(@$"./Pork.Core/Map/{room}.txt"));
                    break;

                default:
                    Console.WriteLine("I don't understand what you are saying.");
                    break;
            }
        }
    }
}