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
            CreateMap<CreateAnswerDTO, Answer>();
            CreateMap<CreateQuestionDTO, Question>()
            .ForMember(dest => dest.QAnswers, act => act.MapFrom(src => src.AddedAnswers));
            CreateMap<CreateSurveyDTO, Survey>()
            .ForMember(dest => dest.SurveyQuestions , act => act.MapFrom(src => src.QuestionsToAdd));
            CreateMap<Survey, SurveyDTO>();
            CreateMap<Question, QuestionDTO>();
            CreateMap<Answer, AnswerDTO>();
            CreateMap<ResponseDTO, Response>();
            CreateMap<Survey, SurveyViewDTO>();
            
        }
    }
}