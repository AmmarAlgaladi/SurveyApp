using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class ResponseDTO
    {
        public string ResponseText { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
    }
}