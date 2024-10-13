using EnglishLearnAPI.Models.Enrollment;
using System.ComponentModel.DataAnnotations;
namespace EnglishLearnAPI.Models.User
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public required string FistName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public required ICollection<EnrollmentModel> Enrollments { get; set; }
    }
}
