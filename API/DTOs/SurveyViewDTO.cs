using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class SurveyViewDTO
    {   
        public int Id { get; set; } 
        public string Title { get; set; }
        public int ResponseCount { get; set; }

    }
}