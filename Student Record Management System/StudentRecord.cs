using System;

namespace StudentRecord
{
    public class Node
    {
        public Node? next;
        public int Id;
        public string Name;
        public string Course;
        public int YearLevel;
        public float GPA;
        public string Position;

        public Node(int Id, string Name, string Course, int YearLevel, float GPA, string Position)
        {
            this.Id = Id;
            this.Name = Name;
            this.Course = Course;
            this.YearLevel = YearLevel;
            this.GPA = GPA;
            this.Position = Position;
            next = null;
        }
    }

    public class StudentLinkedList
    {
        private Node? head;

        public void Add()
        {
            Console.Write("Enter Student ID: ");
            int Id = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Student Name: ");
            string Name = Console.ReadLine()!;

            Console.Write("Enter Course: ");
            string Course = Console.ReadLine()!;

            Console.Write("Enter Year Level: ");
            int YearLevel = int.Parse(Console.ReadLine()!);

            Console.Write("Enter GPA: ");
            float GPA = float.Parse(Console.ReadLine()!);

            Console.Write("Insert at (1) Beginning or (2) End? Enter 1 or 2: ");
            int choice = int.Parse(Console.ReadLine()!);

            string positionTag = (choice == 1) ? "Beginning" : "End";
            Node newNode = new Node(Id, Name, Course, YearLevel, GPA, positionTag);

            if (choice == 1 || head == null)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }

            Console.WriteLine($"Student inserted successfully at the {positionTag}.");
        }

        public void Delete(int id)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.Id == id)
            {
                head = head.next;
                Console.WriteLine("Student has been deleted!");
                return;
            }

            Node temp = head;
            while (temp.next != null && temp.next.Id != id)
            {
                temp = temp.next;
            }

            if (temp.next == null)
            {
                Console.WriteLine("Student not found.");
            }
            else
            {
                temp.next = temp.next.next;
                Console.WriteLine("Student has been deleted!");
            }
        }

        public void Search(int id)
        {
            Console.Write("Enter Student Name: ");
            string? name = Console.ReadLine();

            Node? temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Id == id && temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Student Found ID: {temp.Id}, Name: {temp.Name}, Course: {temp.Course}, Year Level: {temp.YearLevel}, GPA: {temp.GPA}");
                    found = true;
                    break;
                }
                temp = temp.next;
            }

            if (!found)
            {
                Console.WriteLine("Student not found with matching ID and Name.");
            }
        }

        public void Update(int id)
        {
            Node? temp = head;
            while (temp != null)
            {
                if (temp.Id == id)
                {
                    Console.WriteLine("Updating student details...");

                    Console.Write("Enter new Name: ");
                    temp.Name = Console.ReadLine()!;

                    Console.Write("Enter new Course: ");
                    temp.Course = Console.ReadLine()!;

                    Console.Write("Enter new Year Level: ");
                    temp.YearLevel = int.Parse(Console.ReadLine()!);

                    Console.Write("Enter new GPA: ");
                    temp.GPA = float.Parse(Console.ReadLine()!);

                    Console.WriteLine("Student details updated successfully!");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Student not found.");
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No students in the list.");
                return;
            }

            Node? temp = head;
            int count = 1;

            Console.WriteLine("\n Student Records ");
            while (temp != null)
            {
                Console.WriteLine($"\nRecord #{count} ({temp.Position})");
                Console.WriteLine("--------------------------------");
                Console.WriteLine($" ID        : {temp.Id}       ");
                Console.WriteLine($" Name      : {temp.Name}     ");
                Console.WriteLine($" Course    : {temp.Course}   ");
                Console.WriteLine($" Year Level: {temp.YearLevel}");
                Console.WriteLine($" GPA       : {temp.GPA}      ");
                Console.WriteLine("--------------------------------");

                temp = temp.next;
                count++;
            }
        }
    }
}