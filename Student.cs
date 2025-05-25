using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Student
    {
        private int indexNumber;
        private string name;
        private double gpa;
        private int admissionYear;
        private string nic;

        public int IndexNumber { get => indexNumber; set => indexNumber = value; }
        public string Name { get => name; set => name = value; }
        public int AdmissionYear { get => admissionYear; set => admissionYear = value; }
        public string Nic { get => nic; set => nic = value; }
        public double Gpa { get => gpa; set => gpa = value; }
    }
}