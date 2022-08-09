using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class SurveyDTO
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        // public int QuestionCount { get; set; }
        public int ResponseCount { get; set; } = 0;
        public ICollection<Question> SurveyQuestions { get; set; }
    }
}