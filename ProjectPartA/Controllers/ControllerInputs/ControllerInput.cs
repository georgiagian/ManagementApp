using ProjectPartA.Core.Entities;
using ProjectPartA.HelperClasses.PairInputDates;
using ProjectPartA.Repositories.RepositoryInputEntities;
using ProjectPartA.Validations;
using ProjectPartA.View.ViewCreateEntities;
using ProjectPartA.View.ViewMenus;
using ProjectPartA.View.ViewPairEntities;
using ProjectPartA.View.ViewTablesOfData;
using System;
using System.Collections.Generic;

namespace ProjectPartA.Controllers.ControllerInputs
{
    public class ControllerInput
    {
        RepositoryInputEntity rie = new RepositoryInputEntity();

        public void PrintCreationData()
        {
            string option;
            do
            {
                ViewCreateMenu.PrintCreationMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an option from 1 to 7");
                Console.ResetColor();
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (option)
                {
                    case "1": CreateInputedCourse(); break;
                    case "2": CreateInputedTrainer(); break;
                    case "3": CreateInputedStudent(); break;
                    case "4": CreateInputedAssignment(); break;
                    case "5": if (Validation.IsCountZero(rie.GetCourses(), rie.GetTrainers())) { PairTrainersPerCourse(); } break;
                    case "6": if (Validation.IsCountZero(rie.GetCourses(), rie.GetStudents())) { PairStudentsPerCourse(); } break;
                    case "7": if (Validation.IsCountZero(rie.GetCourses(), rie.GetAssignments())) { PairAssignmentsPerCourse(); } break;
                    case "E": Console.Clear(); break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please Enter a Number from 1 to 7"); Console.ResetColor(); break;
                }
                Console.WriteLine("\n\n");
                Console.Clear();
            } while (option != "E");
        }

        public void PrintInputedData()
        {
            string option;
            do
            {
                ViewInsideMenu.PrintInsideMenu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose an option from 1 to 10");
                Console.ResetColor();
                option = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (option)
                {
                    case "1": ViewTables.PrintCourses(rie.GetCourses()); break;
                    case "2": ViewTables.PrintTrainers(rie.GetTrainers()); break;
                    case "3": ViewTables.PrintStudents(rie.GetStudents()); break;
                    case "4": ViewTables.PrintAssignments(rie.GetAssignments()); break;
                    case "5": ViewTables.PrintTrainersPerCourse(rie.GetCourses()); break;
                    case "6": ViewTables.PrintStudentsPerCourse(rie.GetCourses()); break;
                    case "7": ViewTables.PrintAssignmentsPerCourse(rie.GetCourses()); break;
                    case "8": ViewTables.PrintAssignmentsPerStudent(rie.GetStudents()); break;
                    case "9": ViewTables.PrintAStudentWithMultiCourses(rie.GetStudents()); break;
                    case "10": ViewTables.PrintStudentsToReturnAssignment(rie.GetAssignments()); break;
                    case "E": Console.Clear(); break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Please Enter a Number from 1 to 10"); Console.ResetColor(); break;
                }
                Console.WriteLine("\n\n");
            } while (option != "E");
        }

        public void CreateInputedCourse()
        {
            ViewCreateCourse vcc = new ViewCreateCourse();
            Course course = vcc.PrintCreateNewCourse();
            rie.CreateCourse(course);
        }

        public void CreateInputedTrainer()
        {
            ViewCreateTrainer vct = new ViewCreateTrainer();
            Trainer trainer = vct.PrintCreateNewTrainer();
            rie.CreateTrainer(trainer);
        }

        public void CreateInputedStudent()
        {
            ViewCreateStudent vcs = new ViewCreateStudent();
            Student student = vcs.PrintCreateNewStudent();
            rie.CreateStudent(student);
        }

        public void CreateInputedAssignment()
        {
            ViewCreateAssignment vca = new ViewCreateAssignment();
            Assignment assignment = vca.PrintCreateNewAssignment();
            rie.CreateAssignment(assignment);
        }

        public void PairTrainersPerCourse()
        {
            ViewPairCoursesTrainers vpct = new ViewPairCoursesTrainers();
            int courseIdToBeFilled = vpct.ChooseCourseToMatch(rie.GetCourses());
            List<int> trainersIdToBeAdded = vpct.ChooseTrainersToAddToCourse(rie.GetTrainers());
            rie.PairTrainersPerCourse(courseIdToBeFilled, trainersIdToBeAdded);
        }

        public void PairStudentsPerCourse()
        {
            ViewPairCoursesStudents vpcs = new ViewPairCoursesStudents();
            int courseIdToBeFilled = vpcs.ChooseCourseToMatch(rie.GetCourses());
            List<int> StudentsIdToBeAdded = vpcs.ChooseStudentsToAddToCourse(rie.GetStudents());
            rie.PairStudentsPerCourse(courseIdToBeFilled, StudentsIdToBeAdded);
        }

        public void PairAssignmentsPerCourse()
        {
            ViewPairCourseAssignments vpca = new ViewPairCourseAssignments();
            int courseIdToBeFilled = vpca.ChooseCourseToMatch(rie.GetCourses());
            List<int> AssignmentsIdToBeAdded = vpca.ChooseAssignmentsToAddToCourse(rie.GetAssignments());
            rie.PairAssignmentsPerCourse(courseIdToBeFilled, AssignmentsIdToBeAdded);
        }
    }
}
