using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Node
    {
        private Student student;
        private Node next;

        internal Student Student { get => student; set => student = value; }
        internal Node Next { get => next; set => next = value; }
    }
}