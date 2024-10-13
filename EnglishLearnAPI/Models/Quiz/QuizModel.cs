using EnglishLearnAPI.Models.Question;
using System.ComponentModel.DataAnnotations;

namespace EnglishLearnAPI.Models.Quiz
{
    public class QuizModel
    {
        [Key]
        public int QuizId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        public string Description { get; set; }

        public int CourseId { get; set; }

        // Relacionamentos
        public ICollection<QuestionModel> Questions { get; set; }
    }
}
