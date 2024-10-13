using EnglishLearnAPI.Models.Enrollment;
using EnglishLearnAPI.Models.Quiz;
using System.ComponentModel.DataAnnotations;

namespace EnglishLearnAPI.Models.Course
{
    public class CourseModel
    {
        [Key]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters.")]
        public required string Title { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "Course Level is required.")]
        public CourseLevel Level { get; set; } 

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; } = DateTime.UtcNow; 

        // Relacionamentos
        public ICollection<QuizModel> Quizzes { get; set; }
        public ICollection<EnrollmentModel> Enrollments { get; set; }

        public static implicit operator CourseModel(List<CourseModel> v)
        {
            throw new NotImplementedException();
        }
    }
}
