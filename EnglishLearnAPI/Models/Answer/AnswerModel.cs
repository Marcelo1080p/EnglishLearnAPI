using System.ComponentModel.DataAnnotations;

namespace EnglishLearnAPI.Models.Answer
{
    public class AnswerModel
    {
        [Key]
        public int AnswerId { get; set; }

        [Required(ErrorMessage = "Answer text is required.")]
        public string Text { get; set; }

        public bool IsCorrect { get; set; }

        public int QuestionId { get; set; }
    }
}
