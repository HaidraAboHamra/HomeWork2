using System;

namespace HomeWork2;
class Program
{
    static void Main()
    {
        var list = new LinkedList();  

        while (true)  
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Add element at the beginning");
            Console.WriteLine("2. Add element at the end");
            Console.WriteLine("3. Add element at a specific position");
            Console.WriteLine("4. Remove the first element");
            Console.WriteLine("5. Remove the last element");
            Console.WriteLine("6. Print the list");
            Console.WriteLine("7. Exit the program");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            try
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a value to add at the beginning: ");
                        object dataFirst = Console.ReadLine();
                        list.AddFirst(dataFirst);
                        break;
                    case 2:
                        Console.Write("Enter a value to add at the end: ");
                        object dataLast = Console.ReadLine();
                        list.AddLast(dataLast);
                        break;
                    case 3:
                        Console.Write("Enter position: ");
                        int index = int.Parse(Console.ReadLine());
                        Console.Write("Enter value to add at the specified position: ");
                        object dataAt = Console.ReadLine();
                        list.AddAt(index, dataAt);
                        break;
                    case 4:
                        list.RemoveFirst();
                        Console.WriteLine("First element removed.");
                        break;
                    case 5:
                        list.RemoveLast();
                        Console.WriteLine("Last element removed.");
                        break;
                    case 6:
                        Console.WriteLine("List contents:");
                        list.PrintList();
                        break;
                    case 7:
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
