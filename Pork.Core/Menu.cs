namespace Pork.Core
{
    class Menu
    {
        public static void menu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1. Resume Game");
            Console.WriteLine("2. Restart Game");
            Console.WriteLine("3. Help");
            Console.WriteLine("4. Exit Game");
            Console.Write("What would you like to do? (1-4): ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Write("Resuming game...");
                    break;
                case "2":
                    Console.Clear();
                    Inventory.Reset();
                    Game.Play();
                    break;
                case "3":
                    Console.WriteLine(System.IO.File.ReadAllText(@".\Help.txt"));
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}