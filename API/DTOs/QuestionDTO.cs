using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string QType { get; set; }
        public string Content { get; set; }
        public int SurveyId { get; set; }
        public ICollection<AnswerDTO> QAnswers { get; set; }
    }
}