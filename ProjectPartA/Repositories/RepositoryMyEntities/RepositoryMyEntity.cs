using ProjectPartA.Core.Entities;
using ProjectPartA.Databases.SyntheticDatabase;
using System.Collections.Generic;

namespace ProjectPartA.Repositories.RepositoryMyEntities
{
    public class RepositoryMyEntity
    {
        private MyDatabase db = new MyDatabase();

        public List<Course> GetCourses()
        {
            return db.Courses;
        }

        public List<Trainer> GetTrainers()
        {
            return db.Trainers;
        }

        public List<Student> GetStudents()
        {
            return db.Students;
        }

        public List<Assignment> GetAssignments()
        {
            return db.Assignments;
        }
    }
}
