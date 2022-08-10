using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ResponseController :BaseApiController
    {
        private readonly ISurveyRepository _surveyRepository;
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ResponseController(ISurveyRepository surveyRepository, DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
            _surveyRepository = surveyRepository;
        }

        [HttpPost]
        public async Task<ActionResult<Response>> CreateResponse(string Response, int AnswerId)
        {
            var answer = await _surveyRepository.GetAnswerFromIdAsync(AnswerId);
            Response userResponse = new Response
            {
               ResponseText = Response,
               QuestionId = answer.QuestionId,
               AnswerId = answer.Id
            };
            await _context.Responses.AddAsync(userResponse);
            await _surveyRepository.SaveAllAsync();
            return userResponse;
        }
    }
}