using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class SurveyController : BaseApiController
    {
        private readonly IMapper _mapper;
        private readonly ISurveyRepository _surveyRepository;
        private readonly DataContext _context;
        public SurveyController(IMapper mapper, ISurveyRepository surveyRepository, DataContext context)
        {
            _context = context;
            _surveyRepository = surveyRepository;
            _mapper = mapper;
        }


        [HttpPost("add-survey")]
        public async Task<ActionResult<Survey>> AddSurvey(CreateSurveyDTO surveyDTO)
        {
            var survey = _mapper.Map<Survey>(surveyDTO);
            survey.AppUserId = 1;
            _surveyRepository.AddSurvey(survey);
            await _surveyRepository.SaveAllAsync();

            return survey;
            
        }
        
        [HttpGet ("get-survey")]
        public async Task<ActionResult<SurveyDTO>> GetSurvey(int SurveyId)
        {
            return await _surveyRepository.GetSurveyByIdAsync(SurveyId);
        }
    }
}