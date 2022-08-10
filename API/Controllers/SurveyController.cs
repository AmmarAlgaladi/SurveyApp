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
        private readonly IUserRepository _userRepository;
        public SurveyController(IMapper mapper, ISurveyRepository surveyRepository, DataContext context, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _context = context;
            _surveyRepository = surveyRepository;
            _mapper = mapper;
        }

        [HttpGet("Get-surveys")]
        public async Task<IEnumerable<SurveyViewDTO>> GetSurveysAsync(string username)
        {
            var user = await _userRepository.GetUserAsync(username);
            return await _surveyRepository.GetSurveysOfUser(user.Id);
        }


        // [HttpPost("add-survey")]
        // public async Task<ActionResult<Survey>> AddSurvey(CreateSurveyDTO surveyDTO)
        // {   
            
        //     var survey = _mapper.Map<Survey>(surveyDTO);
        //     survey.AppUserId = 1;
        //     _surveyRepository.AddSurvey(survey);
        //     await _surveyRepository.SaveAllAsync();

        //     return survey;
            
        // }

        [HttpPost("add-survey")]
        public async Task<ActionResult<Survey>> AddSurvey(CreateSurveyDTO surveyDTO)
        {   
            var user = await _userRepository.GetUserByUsernameAsync(User.GetUsername());
            var survey = _mapper.Map<Survey>(surveyDTO);
            user.Surveys.Add(survey);
            if (!await _surveyRepository.SaveAllAsync())
            {
                return BadRequest("problem adding survey");
            }

            return survey;
            
        }
        
        [HttpGet]
        public async Task<ActionResult<SurveyDTO>> GetSurvey(int SurveyId)
        {
            return await _surveyRepository.GetSurveyByIdAsync(SurveyId);
        }
    }
}