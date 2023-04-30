using System;
using System.Collections.Generic;

namespace ProjectPartA.Core.Entities
{
    public class Student
    {
        public Student()
        {
        }

        public Student(int id, string firstName, string lastName, DateTime dateOfBirth, int tuitionFees)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int TuitionFees { get; set; }

        // Navigation Properties
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
