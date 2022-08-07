using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class RespondentIp
    {   
        public int Id { get; set; }
        public string Ip { get; set; }
        public Survey Survey { get; set; }
        public int SurveyId { get; set; }
    }
}