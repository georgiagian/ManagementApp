using ProjectPartA.Core.Entities;
using ProjectPartA.Core.Enums;
using ProjectPartA.HelperClasses.PairEntities;
using System;
using System.Collections.Generic;

namespace ProjectPartA.Databases.SyntheticDatabase
{
    public class MyDatabase
    {
        // Properties of Database
        public List<Course> Courses { get; } = new List<Course>();

        public List<Trainer> Trainers { get; } = new List<Trainer>();

        public List<Student> Students { get; } = new List<Student>();

        public List<Assignment> Assignments { get; } = new List<Assignment>();

        // Constructor for Synthetic Data
        public MyDatabase()
        {
            #region Seeding Courses

            // Seeding Courses
            Course c1 = new Course(1, "C#", "CB-8", CourseType.FullTime, new DateTime(2021, 10, 11), new DateTime(2022, 04, 11));
            Course c2 = new Course(2, "C#", "CB-8", CourseType.PartTime, new DateTime(2021, 10, 11), new DateTime(2022, 01, 11));
            Course c3 = new Course(3, "Java", "CB-8", CourseType.FullTime, new DateTime(2021, 11, 20), new DateTime(2022, 04, 11));
            Course c4 = new Course(4, "Java", "CB-8", CourseType.PartTime, new DateTime(2021, 11, 20), new DateTime(2022, 01, 11));
            List<Course> courses = new List<Course>() { c1, c2, c3, c4 };
            #endregion

            #region Seeding Trainers

            // Seeding Trainers
            Trainer t1 = new Trainer(1, "Panos", "Sakelarios", "C#, Java");
            PairEntity.PairCourseTrainer(c2, t1);
            PairEntity.PairCourseTrainer(c4, t1);

            Trainer t2 = new Trainer(2, "Stauros", "Gouleas", "C#");
            PairEntity.PairCourseTrainer(c1, t2);

            Trainer t3 = new Trainer(3, "George", "Kessopoulos", "Java");
            PairEntity.PairCourseTrainer(c3, t3);

            Trainer t4 = new Trainer(4, "Hlias", "Karagewrgos", "Java");
            PairEntity.PairCourseTrainer(c3, t4);

            Trainer t5 = new Trainer(5, "Xarhs", "Papamixahl", "C#, Java");
            PairEntity.PairCourseTrainer(c2, t5);
            PairEntity.PairCourseTrainer(c4, t5);
            #endregion

            #region Seeding Students

            // Seeding Students
            Student s1 = new Student(1, "Labros", "Papadimitriou", new DateTime(1992, 07, 18), 2500);
            PairEntity.PairCourseStudent(c1, s1);

            Student s2 = new Student(2, "Giannis", "Mpatsinilas", new DateTime(1992, 10, 20), 4000);
            PairEntity.PairCourseStudent(c1, s2);

            Student s3 = new Student(3, "Michalhs", "Kiaoulias", new DateTime(1991, 05, 13), 3000);
            PairEntity.PairCourseStudent(c1, s3);

            Student s4 = new Student(4, "Viktoria", "Rontirh", new DateTime(1990, 12, 20), 3500);
            PairEntity.PairCourseStudent(c1, s4);

            Student s5 = new Student(5, "Vera", "Romanou", new DateTime(1992, 06, 17), 2500);
            PairEntity.PairCourseStudent(c1, s5);

            Student s6 = new Student(6, "Kostas", "Merzioths", new DateTime(1992, 07, 18), 2500);
            PairEntity.PairCourseStudent(c1, s6);

            Student s7 = new Student(7, "Eygenios", "Kastanou", new DateTime(1989, 02, 10), 2000);
            PairEntity.PairCourseStudent(c3, s7);

            Student s8 = new Student(8, "Apostolhs", "Galanhs", new DateTime(1993, 07, 28), 5500);
            PairEntity.PairCourseStudent(c3, s8);

            Student s9 = new Student(9, "Parhs", "Fountoulhs", new DateTime(1988, 05, 22), 3000);
            PairEntity.PairCourseStudent(c3, s9);

            Student s10 = new Student(10, "Thodwrhs", "Safos", new DateTime(1994, 01, 07), 2500);
            PairEntity.PairCourseStudent(c2, s10);
            PairEntity.PairCourseStudent(c4, s10);

            Student s11 = new Student(11, "Giwrgos", "Galazios", new DateTime(1994, 06, 18), 2000);
            PairEntity.PairCourseStudent(c2, s11);
            PairEntity.PairCourseStudent(c4, s11);

            Student s12 = new Student(12, "Manos", "Papoutsakhs", new DateTime(1993, 10, 16), 4000);
            PairEntity.PairCourseStudent(c2, s12);
            PairEntity.PairCourseStudent(c4, s12);

            Student s13 = new Student(13, "Evripidhs", "Papadakhs", new DateTime(1991, 05, 23), 3000);
            PairEntity.PairCourseStudent(c2, s13);
            PairEntity.PairCourseStudent(c4, s13);

            Student s14 = new Student(14, "Ismhnh", "Pardalakh", new DateTime(1990, 10, 19), 3500);
            PairEntity.PairCourseStudent(c2, s14);
            PairEntity.PairCourseStudent(c4, s14);

            Student s15 = new Student(15, "Rania", "Xatzinikolaou", new DateTime(1989, 07, 17), 2500);
            PairEntity.PairCourseStudent(c2, s15);
            PairEntity.PairCourseStudent(c4, s15);

            Student s16 = new Student(16, "Petros", "Tsalkas", new DateTime(1993, 02, 18), 5500);
            PairEntity.PairCourseStudent(c2, s16);
            PairEntity.PairCourseStudent(c4, s16);

            Student s17 = new Student(17, "Nikos", "Kalpakos", new DateTime(1990, 03, 08), 3000);
            PairEntity.PairCourseStudent(c2, s17);
            PairEntity.PairCourseStudent(c4, s17);

            Student s18 = new Student(18, "Alexhs", "Papastergiou", new DateTime(1985, 07, 25), 5000);
            PairEntity.PairCourseStudent(c2, s18);
            PairEntity.PairCourseStudent(c4, s18);

            Student s19 = new Student(19, "Nikos", "Ioannoglou", new DateTime(1987, 06, 23), 3500);
            PairEntity.PairCourseStudent(c2, s19);
            PairEntity.PairCourseStudent(c4, s19);

            Student s20 = new Student(20, "Vasiliki", "Flevarh", new DateTime(1991, 02, 17), 2000);
            PairEntity.PairCourseStudent(c2, s20);
            PairEntity.PairCourseStudent(c4, s20);

            #endregion

            #region Seeding Assignments
            // Seeding Assignments
            Assignment a1 = new Assignment(1, "Addition_C#_Full", "Add 2 Numbers", new DateTime(2021, 10, 30), 40, 100);
            PairEntity.PairCourseAssignment(c1, a1);

            Assignment a2 = new Assignment(2, "Substract_C#_Full", "Substract 2 Numbers", new DateTime(2021, 11, 25), 40, 100);
            PairEntity.PairCourseAssignment(c1, a2);

            Assignment a3 = new Assignment(3, "Multiply_C#_Full", "Multiply 2 Numbers", new DateTime(2021, 12, 30), 40, 100);
            PairEntity.PairCourseAssignment(c1, a3);

            Assignment a4 = new Assignment(4, "Division_C#_Full", "Divide 2 Numbers", new DateTime(2022, 01, 27), 40, 100);
            PairEntity.PairCourseAssignment(c1, a4);

            Assignment a5 = new Assignment(5, "Power_C#_Full", "Find Power of 111", new DateTime(2022, 02, 28), 40, 100);
            PairEntity.PairCourseAssignment(c1, a5);

            Assignment a6 = new Assignment(6, "Square_C#_Full", "Find Square of 10", new DateTime(2022, 03, 18), 40, 100);
            PairEntity.PairCourseAssignment(c1, a6);

            Assignment a7 = new Assignment(7, "Complex_C#_Full", "Create a Complex Number", new DateTime(2022, 04, 05), 40, 100);
            PairEntity.PairCourseAssignment(c1, a7);

            Assignment a8 = new Assignment(8, "Addition_C#_Part", "Add 3 Numbers", new DateTime(2021, 10, 15), 60, 100);
            PairEntity.PairCourseAssignment(c2, a8);

            Assignment a9 = new Assignment(9, "Substract_C#_Part", "Substract 3 Numbers", new DateTime(2021, 10, 30), 60, 100);
            PairEntity.PairCourseAssignment(c2, a9);

            Assignment a10 = new Assignment(10, "Multiply_C#_Part", "Multiply 3 Numbers", new DateTime(2021, 11, 09), 60, 100);
            PairEntity.PairCourseAssignment(c2, a10);

            Assignment a11 = new Assignment(11, "Division_C#_Part", "Divide 3 Numbers", new DateTime(2021, 11, 22), 60, 100);
            PairEntity.PairCourseAssignment(c2, a11);

            Assignment a12 = new Assignment(12, "Power_C#_Part", "Find Power of 222", new DateTime(2021, 12, 10), 60, 100);
            PairEntity.PairCourseAssignment(c2, a12);

            Assignment a13 = new Assignment(13, "Square_C#_Part", "Find Square of 15", new DateTime(2021, 12, 22), 60, 100);
            PairEntity.PairCourseAssignment(c2, a13);

            Assignment a14 = new Assignment(14, "Complex_C#_Part", "Create two Complex Numbers", new DateTime(2022, 01, 08), 60, 100);
            PairEntity.PairCourseAssignment(c2, a14);

            Assignment a15 = new Assignment(15, "Addition_Java_Full", "Add 4 Numbers", new DateTime(2021, 10, 23), 40, 100);
            PairEntity.PairCourseAssignment(c3, a15);

            Assignment a16 = new Assignment(16, "Substract_Java_Full", "Substract 4 Numbers", new DateTime(2021, 11, 18), 40, 100);
            PairEntity.PairCourseAssignment(c3, a16);

            Assignment a17 = new Assignment(17, "Multiply_Java_Full", "Multiply 4 Numbers", new DateTime(2021, 12, 22), 40, 100);
            PairEntity.PairCourseAssignment(c3, a17);

            Assignment a18 = new Assignment(18, "Division_Java_Full", "Divide 4 Numbers", new DateTime(2022, 01, 21), 40, 100);
            PairEntity.PairCourseAssignment(c3, a18);

            Assignment a19 = new Assignment(19, "Power_Java_Full", "Find Power of 333", new DateTime(2022, 02, 21), 40, 100);
            PairEntity.PairCourseAssignment(c3, a19);

            Assignment a20 = new Assignment(20, "Square_Java_Full", "Find Square of 20", new DateTime(2022, 03, 14), 40, 100);
            PairEntity.PairCourseAssignment(c3, a20);

            Assignment a21 = new Assignment(21, "Complex_Java_Full", "Create three Complex Numbers", new DateTime(2022, 04, 01), 40, 100);
            PairEntity.PairCourseAssignment(c3, a21);

            Assignment a22 = new Assignment(22, "Addition_Java_Part", "Add 4 Numbers", new DateTime(2021, 10, 17), 60, 100);
            PairEntity.PairCourseAssignment(c4, a22);

            Assignment a23 = new Assignment(23, "Substract_Java_Part", "Substract 4 Numbers", new DateTime(2021, 10, 28), 60, 100);
            PairEntity.PairCourseAssignment(c4, a23);

            Assignment a24 = new Assignment(24, "Multiply_Java_Part", "Multiply 4 Numbers", new DateTime(2021, 11, 06), 60, 100);
            PairEntity.PairCourseAssignment(c4, a24);

            Assignment a25 = new Assignment(25, "Division_Java_Part", "Divide 4 Numbers", new DateTime(2021, 11, 19), 60, 100);
            PairEntity.PairCourseAssignment(c4, a25);

            Assignment a26 = new Assignment(26, "Power_Java_Part", "Find Power of 444", new DateTime(2021, 12, 08), 60, 100);
            PairEntity.PairCourseAssignment(c4, a26);

            Assignment a27 = new Assignment(27, "Square_Java_Part", "Find Square of 25", new DateTime(2021, 12, 20), 60, 100);
            PairEntity.PairCourseAssignment(c4, a27);

            Assignment a28 = new Assignment(28, "Complex_Java_Part", "Create four Complex Numbers", new DateTime(2022, 01, 06), 60, 100);
            PairEntity.PairCourseAssignment(c4, a28);
            #endregion

            #region Populate MyDatabase
            // Populate MyDatabase
            
            Courses.AddRange(courses);

            List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5 };
            Trainers.AddRange(trainers);

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 };
            Students.AddRange(students);

            List<Assignment> assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28 };
            Assignments.AddRange(assignments);
            #endregion
        }
    }
}
