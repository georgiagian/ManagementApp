using System.Collections.Generic;

namespace ProjectPartA.Core.Entities
{
    public class Trainer
    {
        public Trainer()
        {
        }

        public Trainer(int id, string firstName, string lastName, string subject)
        {
            Id = Id;
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Subject { get; set; }

        // Navigation Properties
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
