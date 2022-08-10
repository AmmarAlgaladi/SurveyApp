using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ISurveyRepository
    {
        void AddSurvey (Survey survey);
        Task<SurveyDTO> GetSurveyByIdAsync(int Id);
        Task<bool> SaveAllAsync();
        Task<Answer> GetAnswerFromIdAsync(int AnswerId);
        Task<IEnumerable<SurveyViewDTO>> GetSurveysOfUser(int userId);
        // Task<Survey> GetSurvey(int id);
        // Task<IEnumerable<SurveyDTO>> GetSurveysForUser(string username);
        // Task<bool> SaveAllAsync();
    }
}