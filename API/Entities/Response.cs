using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public string ResponseText { get; set; }
        // public Question Question { get; set; }
        public int QuestionId { get; set; }
        // public Answer Answers { get; set; }

        public int AnswerId { get; set; }
    }
}