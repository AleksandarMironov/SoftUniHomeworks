using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HumanStudentWorker
{
    internal class Student : Human
    {
        private const int MinFacultyNumberLenght = 5;
        private const int maxFacultyNumberLenght = 10;
        private int facultyNumber;

        public Student(string firstName, string lastName, int facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.ToString().Length < MinFacultyNumberLenght || value.ToString().Length > maxFacultyNumberLenght)
                {
                    throw new ArgumentOutOfRangeException("Faculty number has to be in range [5...10] digits ");
                }
                this.facultyNumber = value;
            }
        }
    }
}
