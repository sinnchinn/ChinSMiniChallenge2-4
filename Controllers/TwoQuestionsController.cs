using ChinSMiniChallenge2_4.services.twoquestions;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge2_4.Controllers;

[ApiController]
[Route("controllers")]

public class TwoQuestionsController : ControllerBase
{
    private readonly ITwoQuestionsService _twoQuestionsService;

    public TwoQuestionsController(ITwoQuestionsService twoQuestionsService)
    {
        _twoQuestionsService = twoQuestionsService;
    }

    [HttpPost]
    [Route("TwoQuestions/{userName}, {wakeUpTime}")]

    public string TwoQuestions(string userName, string wakeUpTime)
    {
        return _twoQuestionsService.TwoQuestions(userName, wakeUpTime);

    }

}