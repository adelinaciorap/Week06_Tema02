using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _01.Student123
{
    public class Student : ICloneable, IComparable<Student>
    {


        public Student(string firstName, string middleName, string lastName, int sSN, string address, int mobile, string email, int course, Speciality speciality, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.Address = address;
            this.Mobile = mobile;
            this.Email = email;
            this.Course = course;
            this.Specialty = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Address { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Speciality Specialty { get; set; }




        // Override Equals() method
        public override bool Equals(object s)
        {
            Student student = s as Student;

            if (student == null)
            {
                return false;
            }
            if (student.FirstName == this.FirstName && student.MiddleName == this.MiddleName && student.LastName == LastName && student.SSN == this.SSN && student.Address == this.Address
                 && student.Mobile == this.Mobile && student.Email == this.Email && student.Course == this.Course && student.Specialty == Specialty && student.University == this.University
                 && student.Faculty == this.Faculty)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // Override ToString() method

        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName} {SSN} {University} {Faculty}";
        }


        // Override == operator


        public static bool operator ==(Student std1, Student std2)
        {
            return Student.Equals(std1, std2);
        }

        // Override != operator
        public static bool operator !=(Student std1, Student std2)
        {
            return !(Student.Equals(std1, std2));

        }

        // GetHashCode
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
        }


        // ICloneable
        object ICloneable.Clone()
        {
            return this.Clone();
        }


        public Student Clone()
        {
            Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.Mobile, this.Email, this.Course, this.Specialty, this.University, this.Faculty);

            return result;
        }

        //IComparable


        public int CompareTo(Student currentStudent)
        {
            int firstNameCompare = this.FirstName.CompareTo(currentStudent.FirstName);

            if (firstNameCompare != 0)
            {
                return firstNameCompare;
            }
            else
            {
                int middleNameCompare = this.MiddleName.CompareTo(currentStudent.MiddleName);

                if (middleNameCompare != 0)
                {
                    return middleNameCompare;
                }
                else
                {
                    int lastNameCompare = this.LastName.CompareTo(currentStudent.LastName);

                    if (lastNameCompare != 0)
                    {
                        return lastNameCompare;
                    }
                    else
                    {
                        int SSNCompare = this.SSN.CompareTo(currentStudent.SSN);

                        if (SSNCompare != 0)
                        {
                            return SSNCompare;
                        }

                        else
                        {
                            return 0;
                        }
                    }


                }
            }
        }
    }
}

