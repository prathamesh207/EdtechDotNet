namespace Edtech.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseTitle { get; set; }

        public string InstructorName { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }

        public int Price { get; set; }



    }
}
