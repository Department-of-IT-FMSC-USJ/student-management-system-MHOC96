using System.Xml.Linq;

namespace Student_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglylLinkedList list = new SinglylLinkedList();

            Console.WriteLine("Welcome to the Student Management System\n");
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n1. Insert Student\n2. Search Student\n3. Delete Student\n4. Print All\n5. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Student s = new Student();
                        Console.Write("Enter Index Number: ");
                        s.IndexNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        s.Name = Console.ReadLine();
                        Console.Write("Enter GPA: ");
                        s.Gpa = double.Parse(Console.ReadLine());
                        Console.Write("Enter Admission Year: ");
                        s.AdmissionYear = int.Parse(Console.ReadLine());
                        Console.Write("Enter NIC: ");
                        s.Nic = Console.ReadLine();

                        list.AddStudent(new Node { Student = s });
                        break;

                    case 2:
                        Console.Write("Enter Index Number to Search: ");
                        int searchIndex = int.Parse(Console.ReadLine());
                        var found = list.GetStudent(searchIndex);
                        if (found != null)
                            Console.WriteLine($"Found: {found.Student.Name}, GPA: {found.Student.Gpa}");
                        else
                            Console.WriteLine("Student not found.");
                        break;

                    case 3:
                        Console.Write("Enter Index Number to Delete: ");
                        int delIndex = int.Parse(Console.ReadLine());
                        list.RemoveStudent(delIndex);
                        Console.WriteLine("Removed if existed.");
                        break;

                    case 4:
                        list.printList();
                        break;

                    case 5:
                        exit = true;
                        break;
                    case 6:
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}