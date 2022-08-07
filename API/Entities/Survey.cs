using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Survey
    {
        public int Id { get; set; } 

        public string Title { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int ResponseCount { get; set; }
        public bool HasResonse { get; set; }

        public AppUser AppUser { get; set; }

        public int AppUserId { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<RespondentIp> RespondentIps { get; set; }

    }
}