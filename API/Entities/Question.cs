using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string QType { get; set; }
        public string Content { get; set; }
        public Survey Survey { get; set; }

        public int SurveyId { get; set; }
        public ICollection<Response> Responses { get; set; }




    }
    
}