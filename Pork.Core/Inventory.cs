namespace Pork.Core
{
    public class Inventory
    {
        public static List<string> inventory = new List<string>();
        public static List<string> usedItems = new List<string>();
        public static void AddItem(string item)
        {
            if (inventory.Contains(item))
            {
                Console.WriteLine("You already have that item.");
            }
            else {
                inventory.Add(item);
                Console.WriteLine($"--> You've optained a {item}. <--");
            }
        }
        public static void RemoveItem(string item)
        {
            inventory.Remove(item);
        }
        public static void ListItems()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("You have nothing in your inventory.");
            }
            else
            {
                Console.WriteLine("You have the following items in your inventory:");
                foreach (string item in inventory)
                {
                    Console.WriteLine("-> " + item);
                }
            }
        }
        public static void GetItem(string item)
        {
            if (inventory.Contains(item))
            {
                return;
            }
            else
            {
                return;
            }
        }
        public static void UseItem(string item)
        {
            if (inventory.Contains(item))
            {
                usedItems.Add(item);
                inventory.Remove(item);
                Console.WriteLine($"You have used {item}.");
            }
            else
            {
                Console.WriteLine($"You do not have {item} in your inventory.");
            }
        }
        public static void Reset()
        {
            inventory.Clear();
            usedItems.Clear();
        }
    }
}