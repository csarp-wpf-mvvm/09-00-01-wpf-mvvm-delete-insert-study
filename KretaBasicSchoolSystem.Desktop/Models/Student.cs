using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.Models
{
    public enum SchoolClassType { ClassA, ClassB, ClassC }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public int SchoolYear { get; set; }
        public SchoolClassType SchoolClass { get; set; }
        public string EducationLevel { get; set; }

        public Student(string firstName, string lastName, DateTime birthsDay, int schoolYear, SchoolClassType schoolClass, string educationLevel)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            SchoolYear = schoolYear;
            SchoolClass = schoolClass;
            EducationLevel = educationLevel;
        }

        public Student()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            SchoolYear = 9;
            SchoolClass = SchoolClassType.ClassA;
            EducationLevel = string.Empty;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} ({SchoolYear}.{SchoolClass}) - ({String.Format("{0:yyyy.MM.dd.}", BirthsDay)}) ({EducationLevel})";
        }
    }
}
