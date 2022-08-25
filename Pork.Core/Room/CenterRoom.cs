namespace Pork.Core.Room
{
    class CenterRoom
    {
        public static void room(bool firstTime)
        {
            bool tableUnlocked = false;
            if (firstTime == true)
            {
                Console.WriteLine("As you enter the room, you see that it's a large circular room with 5 doors around the walls.");
                Console.WriteLine("You notice a table in the middle of the room");
            }
            while (tableUnlocked == false)
            {
                Console.Write("> ");
                string answer = Console.ReadLine();
                switch (answer.ToLower())
                {
                    case "check table":
                        Console.WriteLine("You see 5 different colored keyholes on the table.");
                        Console.WriteLine("--> Red");
                        Console.WriteLine("--> Blue");
                        Console.WriteLine("--> Green");
                        Console.WriteLine("--> Yellow");
                        Console.WriteLine("--> Purple");
                        break;

                    case "check doors":
                        Console.WriteLine("As you check the doors, you notice that they are all different colors.");
                        Console.WriteLine("--> Red");
                        Console.WriteLine("--> Blue");
                        Console.WriteLine("--> Green");
                        Console.WriteLine("--> Yellow");
                        Console.WriteLine("--> Purple");
                        break;

                    case "check room":
                        Console.WriteLine("You see a table in the middle of the room.");
                        Console.WriteLine("You see 5 doors around the room.");
                        break;

                    case "open red door":
                        Console.WriteLine("You open the door and go into the room.");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        RedRoom.room();
                        Console.WriteLine("You are in the center room, with a table in the middle of the room.");
                        break;

                    case "open blue door":
                        Console.WriteLine("You open the door and go into the room.");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        BlueRoom.room();
                        Console.WriteLine("You are in the center room, with a table in the middle of the room.");
                        break;
                    
                    case "open green door":
                        Console.WriteLine("You open the door and go into the room.");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        GreenRoom.room();
                        Console.WriteLine("You are in the center room, with a table in the middle of the room.");
                        break;
                    
                    case "open yellow door":
                        Console.WriteLine("You open the door and go into the room.");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        YellowRoom.room();
                        Console.WriteLine("You are in the center room, with a table in the middle of the room.");
                        break;
                    
                    case "open purple door":
                        Console.WriteLine("You open the door and go into the room.");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        PurpleRoom.room();
                        Console.WriteLine("You are in the center room, with a table in the middle of the room.");
                        break;

                    case "use red key":
                        if (Inventory.inventory.Contains("Red key"))
                        {
                            Console.WriteLine("You put the red key into the keyhole and turn it.");
                            Inventory.UseItem("Red key");
                        }
                        else {
                            Inventory.UseItem("Red key");
                        }
                        break;

                    case "use blue key":
                        if (Inventory.inventory.Contains("Blue key"))
                        {
                            Console.WriteLine("You put the blue key into the keyhole and turn it.");
                            Inventory.UseItem("Blue key");
                        }
                        else {
                            Inventory.UseItem("Blue key");
                        }
                        break;

                    case "use green key":
                        if (Inventory.inventory.Contains("Green key"))
                        {
                            Console.WriteLine("You put the green key into the keyhole and turn it.");
                            Inventory.UseItem("Green key");
                        }
                        else {
                            Inventory.UseItem("Green key");
                        }
                        break;

                    case "use yellow key":
                        if (Inventory.inventory.Contains("Yellow key"))
                        {
                            Console.WriteLine("You put the yellow key into the keyhole and turn it.");
                            Inventory.UseItem("Yellow key");
                        }
                        else {
                            Inventory.UseItem("Yellow key");
                        }
                        break;

                    case "use purple key":
                        if (Inventory.inventory.Contains("Purple key"))
                        {
                            Console.WriteLine("You put the purple key into the keyhole and turn it.");
                            Inventory.UseItem("Purple key");
                        }
                        else {
                            Inventory.UseItem("Purple key");
                        }
                        break;
                    
                    default:
                        Core.SudoCommands.sudo(answer, "CenterRoom");
                        break;
                }
                if (Inventory.usedItems.Contains("Red key") && Inventory.usedItems.Contains("Blue key") && Inventory.usedItems.Contains("Green key") && Inventory.usedItems.Contains("Yellow key") && Inventory.usedItems.Contains("Purple key"))
                {
                    tableUnlocked = true;
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine("As you put in and turn the last key you hear a click.");
                    Console.WriteLine("You feel that the ground begings to shake and the table begins to rise up.");
                    Console.WriteLine("As the table is fully raised up, you see a door thats leading outside.");
                    Console.WriteLine("You smell the fresh air and begins to remember the time outside.");
                    Console.WriteLine("As you look back you are ready to leave.");
                    Console.Write("Are you ready to leave? (y/y) ");
                    string leave = Console.ReadLine();
                    while (leave.ToLower() != "y")
                    {
                        Console.Write("Are you ready to leave? (y/y): ");
                        leave = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("You leave the room.");
            Console.WriteLine("Thanks for playing!");
        }
    }
}