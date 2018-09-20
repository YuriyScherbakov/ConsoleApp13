using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Student
    {
        string lastName;
        int courseNumber;

        public Student(string lastName, int courseNumber)
        {
            this.lastName = lastName;
            this.courseNumber = courseNumber;
        }
        public Student(string lastName) : this(lastName, 1) { }

        public void PrintStudentLastName()
        {
            Console.WriteLine("Student`s last name is {0}", this.lastName);
        }


        public int GetStudentYearsLeft()
        {
            return 5 - this.courseNumber;
        }

        public int CourseNumber
        {
            get
            {
                return this.courseNumber;
            }
            set
            {
                this.courseNumber = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }

        public dynamic this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return this.lastName;
                    case 1: return this.courseNumber;
                    default:
                        {
                            Console.WriteLine("Error");
                            return 0;
                        }
                }
            }
            set
            {
                switch (index)
                {
                    case 0: this.lastName = value; break;
                    case 1: this.courseNumber = value; break;
                    default:
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                }
            }
        }

        public static Student operator ++(Student st)
        {
            st.courseNumber += 1;
            return st;
        }
        public static bool operator <(Student st1, Student st2) => st1.courseNumber < st2.courseNumber;
        public static bool operator >(Student st1, Student st2) => st1.courseNumber > st2.courseNumber;
    }


        class Program
        {
            static void Main(string[] args)
            {
                Student st = new Student("fffff",5);
                Console.WriteLine(st.CourseNumber);
           
                Console.WriteLine(st.LastName);
                Console.WriteLine(st.CourseNumber);

            }
        }
    
}