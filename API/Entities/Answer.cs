using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public string AnswerTxt { get; set; }
        // public Question Question { get; set; }
        public ICollection<Response> Responses { get; set; }
    }
}