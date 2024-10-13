using EnglishLearnAPI.Models.Course;


namespace EnglishLearnAPI.Dto.CourseDto
{
    public class CreateCourseDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public CourseLevel Level { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    }
}
