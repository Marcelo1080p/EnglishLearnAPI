using EnglishLearnAPI.Models.Answer;
using System.ComponentModel.DataAnnotations;

namespace EnglishLearnAPI.Models.Question
{
    public class QuestionModel
    {
        [Key]
        public int QuestionId { get; set; }

        [Required(ErrorMessage = "Question text is required.")]
        public string Text { get; set; }

        public int QuizId { get; set; }

        // Relacionamentos
        public ICollection<AnswerModel> Answers { get; set; }
    }
}
