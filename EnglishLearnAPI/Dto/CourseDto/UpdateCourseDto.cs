using EnglishLearnAPI.Models.Course;

namespace EnglishLearnAPI.Dto.CourseDto
{
    public class UpdateCourseDto
    {
        public int CourseId { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public CourseLevel Level { get; set; }
    }
}
