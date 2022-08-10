using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class CreateQuestionDTO
    {
        public string QType { get; set; }
        public string Content { get; set; }
        // public int ChoiceCount { get; set; }
        public List<CreateAnswerDTO> AddedAnswers { get; set; }
        // public ICollection<AnswerDTO> Answers { get; set; }

    }
}