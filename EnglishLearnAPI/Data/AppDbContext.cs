using Microsoft.EntityFrameworkCore;
using EnglishLearnAPI.Models.Answer;
using EnglishLearnAPI.Models.Course;
using EnglishLearnAPI.Models.Enrollment;
using EnglishLearnAPI.Models.Question;
using EnglishLearnAPI.Models.Quiz;
using EnglishLearnAPI.Models.User;

namespace EnglishLearnAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<AnswerModel> Answers { get; set; }
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<EnrollmentModel> Enrollments { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<QuizModel> Quizzes { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
