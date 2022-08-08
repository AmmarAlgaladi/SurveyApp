using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, UserDTO>();
            CreateMap<RegisterDTO, AppUser>();
            CreateMap<QuestionDTO, Question>();
            CreateMap<CreateSurveyDTO, Survey>()
            .ForMember(dest => dest.SurveyQuestions , act => act.MapFrom(src => src.Question1));
            CreateMap<AnswerDTO, Answer>();
        }
    }
}