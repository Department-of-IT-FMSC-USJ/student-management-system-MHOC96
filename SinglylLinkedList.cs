using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class SinglylLinkedList
    {
        private Node head;
        private Node tail;

        internal Node Tail { get => tail; set => tail = value; }
        internal Node Head { get => head; set => head = value; }

        public SinglylLinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddStudent(Node student)
        {
            if (head == null || student.Student.IndexNumber < head.Student.IndexNumber)
            {
                student.Next = head;
                head = student;
                return;
            }
            Node current = head;
            while (current.Next != null && current.Next.Student.IndexNumber < student.Student.IndexNumber)
            {
                if (current.Student.IndexNumber == student.Student.IndexNumber)
                {
                    Console.WriteLine("Student with this index number already exists.");
                    return;
                }
                current = current.Next;
            }
            if (current.Next != null && current.Next.Student.IndexNumber == student.Student.IndexNumber)
            {
                Console.WriteLine("Student with this index number already exists.");
                return;
            }
            student.Next = current.Next;
            current.Next = student;
        }

        public Node GetStudent(int indexNumber)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Student.IndexNumber == indexNumber)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
        public void RemoveStudent(int indexNumber)
        {
            if (head == null)
            {
                return;
            }
            if (head.Student.IndexNumber == indexNumber)
            {
                head = head.Next;
                return;
            }
            Node previous = head;
            Node current = head;
            while (current != null && current.Student.IndexNumber != indexNumber)
            {
                previous = current;
                current = current.Next;
            }
            if (current == null)
            {
                return;
            }
            previous.Next = current.Next;
        }
        public void printList()
        {
            if (head == null)
            {
                Console.WriteLine("This is no students");
            }
            Node current = head;
            while (current != null)
            {
                Console.WriteLine($"Index: {current.Student.IndexNumber}, Name: {current.Student.Name}, GPA: {current.Student.Gpa}, Year: {current.Student.AdmissionYear}, NIC: {current.Student.Nic}");
                current = current.Next;
            }
        }

    }
}