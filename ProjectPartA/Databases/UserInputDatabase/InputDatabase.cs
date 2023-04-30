using ProjectPartA.Core.Entities;
using System.Collections.Generic;

namespace ProjectPartA.Databases.UserInputDatabase
{
    public class InputDatabase
    {
        public List<Course> Courses { get; } = new List<Course>();

        public List<Trainer> Trainers { get; } = new List<Trainer>();

        public List<Student> Students { get; } = new List<Student>();

        public List<Assignment> Assignments { get; } = new List<Assignment>();
    }
}
