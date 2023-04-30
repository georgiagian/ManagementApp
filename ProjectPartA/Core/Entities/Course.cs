using ProjectPartA.Core.Enums;
using System;
using System.Collections.Generic;

namespace ProjectPartA.Core.Entities
{
    public class Course
    {
        public Course()
        {
        }

        public Course(int id, string title, string stream, CourseType type, DateTime startDate, DateTime endDate)
        {
            Id = id;
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Stream { get; set; }

        public CourseType Type { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        // Navigation Properties
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

    }
}
