namespace ShoppingListManager;

public class Program
{
    public static void Main()
    {
        //1. Structure
        string path = @"C:\Users\erica\Desktop\First  Project\ShoppingListManager\ShoppingListManager\";
        string fileName = "shopping_list.txt";
        string filePath = path + fileName;

        List<string> shoppingList = new List<string>();

        //2. Logic
        if (File.Exists(filePath))
        {
            shoppingList.AddRange(File.ReadAllLines(filePath));
        }
          
        while (true)
        {
            Console.WriteLine("\n=== Shopping List ===");
            Console.WriteLine("1.Add item");
            Console.WriteLine("2.Remove item");
            Console.WriteLine("3. Show list");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose a number for continue:");

            string choiceUser = Console.ReadLine();

            switch (choiceUser)
            {
                case "1":
                    Console.WriteLine("Type item name:");
                    string itemInsert = Console.ReadLine();
                    if (!string.IsNullOrEmpty(itemInsert))
                    {
                        shoppingList.Add(itemInsert);
                        Console.WriteLine($"Item {itemInsert} added successfully.");
                    } else
                    {
                        Console.WriteLine("Item cannot be empty!");
                    }
                    break;

                case "2":
                    Console.WriteLine("Type item name to remove:");
                    string itemToRemove = Console.ReadLine();
                    if (shoppingList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"Item '{itemToRemove}' removed successfully.");
                    } else
                    {
                        Console.WriteLine($"Item '{itemToRemove}' not found!");
                    }
                    break;

                case "3":
                    if (shoppingList.Count == 0)
                    {
                        Console.WriteLine("Your list is empty!");
                    }
                    else
                    {
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                        }
                    }

                break;

                case "4":
                    File.WriteAllLines(filePath, shoppingList);
                    Console.WriteLine("List saved successfully.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                break;
            }
        }
    }
}