using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API.Data
{
    public class SurveyRepository : ISurveyRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public SurveyRepository(DataContext context, IMapper mapper, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _context = context;
        }

        public void AddSurvey(Survey survey)
        {
            _context.Surveys.Add(survey);
        }

        public Task<Answer> GetAnswerFromIdAsync(int AnswerId)
        {
            return _context.Answers.FirstOrDefaultAsync(x => x.Id == AnswerId);
        }

        public async Task<SurveyDTO> GetSurveyByIdAsync(int SurveyId)
        {
            return await _context.Surveys.Include(x => x.SurveyQuestions).ThenInclude(y => y.QAnswers)
            .ProjectTo<SurveyDTO>(_mapper.ConfigurationProvider).SingleOrDefaultAsync(x => x.Id == SurveyId);
        }

        public async Task<IEnumerable<SurveyViewDTO>> GetSurveysOfUser(int userId)
        {   
            return await _context.Surveys.Where(x => x.AppUserId == userId).ProjectTo<SurveyViewDTO>(_mapper.ConfigurationProvider)
            .ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}