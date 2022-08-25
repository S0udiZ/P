using Pork.Core;

namespace Pork
{
    public class Pork
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine(" /$$$$$$$ ");
            Console.WriteLine("| $$__  $$");
            Console.WriteLine("| $$  / $$");
            Console.WriteLine("| $$$$$$$/");
            Console.WriteLine("| $$____/ ");
            Console.WriteLine("| $$      ");
            Console.WriteLine("| $$      ");
            Console.WriteLine("|__/      ");

            Thread.Sleep(1000);

            Console.Clear();

            Console.WriteLine(" /$$$$$$$   /$$$$$$ ");
            Console.WriteLine("| $$__  $$ /$$__  $$");
            Console.WriteLine("| $$  / $$| $$  / $$");
            Console.WriteLine("| $$$$$$$/| $$  | $$");
            Console.WriteLine("| $$____/ | $$  | $$");
            Console.WriteLine("| $$      | $$  | $$");
            Console.WriteLine("| $$      |  $$$$$$/");
            Console.WriteLine("|__/       /______/ ");

            Thread.Sleep(1000);

            Console.Clear();

            Console.WriteLine(" /$$$$$$$   /$$$$$$  /$$$$$$$ ");
            Console.WriteLine("| $$__  $$ /$$__  $$| $$__  $$");
            Console.WriteLine("| $$  / $$| $$  / $$| $$  / $$");
            Console.WriteLine("| $$$$$$$/| $$  | $$| $$$$$$$/");
            Console.WriteLine("| $$____/ | $$  | $$| $$__  $$");
            Console.WriteLine("| $$      | $$  | $$| $$  / $$");
            Console.WriteLine("| $$      |  $$$$$$/| $$  | $$");
            Console.WriteLine("|__/       /______/ |__/  |__/");

            Thread.Sleep(1000);
            
            Console.Clear();

            Console.WriteLine(" /$$$$$$$   /$$$$$$  /$$$$$$$  /$$   /$$");
            Console.WriteLine("| $$__  $$ /$$__  $$| $$__  $$| $$  /$$/");
            Console.WriteLine("| $$  / $$| $$  / $$| $$  / $$| $$ /$$/ ");
            Console.WriteLine("| $$$$$$$/| $$  | $$| $$$$$$$/| $$$$$/  ");
            Console.WriteLine("| $$____/ | $$  | $$| $$__  $$| $$  $$  ");
            Console.WriteLine("| $$      | $$  | $$| $$  / $$| $$/  $$ ");
            Console.WriteLine("| $$      |  $$$$$$/| $$  | $$| $$ /  $$");
            Console.WriteLine("|__/       /______/ |__/  |__/|__/  /__/");

            Console.Write("Are you ready to play? (y/n/help): ");
            string answer = Console.ReadLine().ToLower();
            while (answer != "y")
            {
                if (answer == "help")
                {
                    Console.Clear();
                    Console.WriteLine(System.IO.File.ReadAllText(@".\Help.txt"));
                }
                if (answer == "debug")
                {
                    Inventory.AddItem("Red key");
                    Inventory.AddItem("Blue key");
                    Inventory.AddItem("Green key");
                    Inventory.AddItem("Yellow key");
                    Inventory.AddItem("Purple key");
                }
                Console.Write("Are you ready to play? (y/n/help): ");
                answer = Console.ReadLine().ToLower();
            }
            Console.Clear();
            Core.Game.Play();
            Console.WriteLine("--------------------------------------------------------------------------------");
        }
    }
}