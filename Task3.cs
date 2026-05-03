using System;
using System.Collections.Generic;

class Task3
{
    public static void Run()
    {
        List<string> items = new List<string>();
        int choice;
        do
        {
            Console.WriteLine("\n1.Add Item");
            Console.WriteLine("2.Remove Item");
            Console.WriteLine("3.Display Items");
            Console.WriteLine("4.Exit");
            Console.Write("Enter your choice:");

            int.TryParse(Console.ReadLine(),out choice);

            if (choice == 1)
            {
                Console.Write("Enter item name:");

                string item = Console.ReadLine().Trim().ToUpper();

                items.Add(item);

                Console.WriteLine("Item added");
            }
            else if (choice == 2)
            {
                Console.Write("Enter item to remove:");

                string item = Console.ReadLine().Trim().ToUpper();

                if (items.Remove(item))
                {
                    Console.WriteLine("Item removed");
                }
                else
                {
                    Console.WriteLine("Item not found");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("\nItems in List:");

                if (items.Count == 0)
                {
                    Console.WriteLine("List is empty");
                }
                else
                {
                    foreach (string item in items)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else if (choice != 4)
            {
                Console.WriteLine("Invalid choice");
            }

        } while (choice != 4);

        Console.WriteLine("Program Ended");
    }
}