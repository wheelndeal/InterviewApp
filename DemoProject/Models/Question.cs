using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string Answer { get; set; }

        /// <summary>
        /// Gets or sets a hint for this question.
        /// </summary>
        public string Hint { get; set; }
    }

}
