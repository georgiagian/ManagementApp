using ProjectPartA.Core.Entities;
using ProjectPartA.Databases.UserInputDatabase;
using ProjectPartA.HelperClasses.PairEntities;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPartA.Repositories.RepositoryInputEntities
{
    public class RepositoryInputEntity
    {
        private InputDatabase idb = new InputDatabase();

        #region Get Entities
        // Get
        public List<Course> GetCourses()
        {
            return idb.Courses;
        }

        public List<Trainer> GetTrainers()
        {
            return idb.Trainers;
        }

        public List<Student> GetStudents()
        {
            return idb.Students;
        }

        public List<Assignment> GetAssignments()
        {
            return idb.Assignments;
        }
        #endregion

        #region Create Entities
        // Create
        public void CreateCourse(Course course)
        {
            course.Id = idb.Courses.Count == 0 ? 1 : idb.Courses.Last().Id + 1;
            idb.Courses.Add(course);
        }

        public void CreateTrainer(Trainer trainer)
        {
            trainer.Id = idb.Trainers.Count == 0 ? 1 : idb.Trainers.Last().Id + 1;
            idb.Trainers.Add(trainer);
        }

        public void CreateStudent(Student student)
        {
            student.Id = idb.Students.Count == 0 ? 1 : idb.Students.Last().Id + 1;
            idb.Students.Add(student);
        }

        public void CreateAssignment(Assignment assignment)
        {
            assignment.Id = idb.Assignments.Count == 0 ? 1 : idb.Assignments.Last().Id + 1;
            idb.Assignments.Add(assignment);
        }
        #endregion

        #region Pair Entities
        //Pair Entities

        public void PairTrainersPerCourse(int courseId, List<int> trainers)
        {
            var course = idb.Courses.Find(x => x.Id == courseId);
            foreach (var trainerId in trainers)
            {
                var trainer = idb.Trainers.Find(x => x.Id == trainerId);
                if (!course.Trainers.Contains(trainer))
                {
                    PairEntity.PairCourseTrainer(course, trainer);
                }
            }
        }

        public void PairStudentsPerCourse(int courseId, List<int> students)
        {
            var course = idb.Courses.Find(x => x.Id == courseId);
            foreach (var studentId in students)
            {
                var student = idb.Students.Find(x => x.Id == studentId);
                if (!course.Students.Contains(student))
                {
                    PairEntity.PairCourseStudent(course, student);
                }
            }
        }

        public void PairAssignmentsPerCourse(int courseId, List<int> assignments)
        {
            var course = idb.Courses.Find(x => x.Id == courseId);
            foreach (var assignmentId in assignments)
            {
                var assignment = idb.Assignments.Find(x => x.Id == assignmentId);
                if (!course.Assignments.Contains(assignment))
                {
                    PairEntity.PairCourseAssignment(course, assignment);
                }
            }
        }
        #endregion

    }
}
