using System;

namespace ProjectPartA.Core.Entities
{
    public class Assignment
    {
        public Assignment()
        {
        }

        public Assignment(int id, string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            Id = id;
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime SubDateTime { get; set; }

        public int OralMark { get; set; }

        public int TotalMark { get; set; }

        // Navigation Properties
        public Course Course { get; set; } = new Course();
    }
}
