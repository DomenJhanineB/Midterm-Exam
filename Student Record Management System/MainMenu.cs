using System;
using StudentRecord;

namespace Student_Record_Management_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StudentLinkedList list = new StudentLinkedList();
            int choice;

            do
            {
                Console.WriteLine("\n Student Management Menu \n");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Delete Student");
                Console.WriteLine("3. Search Student by ID or Name");
                Console.WriteLine("4. Update Student Details");
                Console.WriteLine("5. Display Students");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice)) continue;

                switch (choice)
                {
                    case 1:
                        list.Add(); 
                        break;

                    case 2:
                        Console.Write("Enter ID to Delete: ");
                        int deleteId = int.Parse(Console.ReadLine()!);
                        list.Delete(deleteId);
                        break;

                    case 3:
                        Console.Write("Enter ID to Search: ");
                        int searchId = int.Parse(Console.ReadLine()!);
                        list.Search(searchId);
                        break;

                    case 4:
                        Console.Write("Enter ID to Update: ");
                        int updateId = int.Parse(Console.ReadLine()!);
                        list.Update(updateId);
                        break;

                    case 5:
                        list.Display();
                        break;

                    case 6:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 6);
        }
    }
}