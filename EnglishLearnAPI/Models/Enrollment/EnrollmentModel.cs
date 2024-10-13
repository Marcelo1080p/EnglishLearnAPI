using System.ComponentModel.DataAnnotations;
using EnglishLearnAPI.Models.User;
using EnglishLearnAPI.Models.Course;
namespace EnglishLearnAPI.Models.Enrollment
{
    public class EnrollmentModel
    {
        [Key]
        public int EnrollmentId { get; set; } 

        [Required(ErrorMessage = "User ID is required.")]
        public int UserId { get; set; } 

        [Required(ErrorMessage = "Course ID is required.")]
        public int CourseId { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Enrollment date is required.")]
        public DateTime EnrollmentDate { get; set; }

        public UserModel User { get; set; }
        public CourseModel Course { get; set; } 
    }
}
