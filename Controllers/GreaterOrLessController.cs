using ChinSMiniChallenge2_4.services.greaterorless;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge2_4.Controllers;

[ApiController]
[Route("controllers")]

public class GreaterOrLessController : ControllerBase
{
    private readonly IGreaterOrLessService _greaterOrLessService;

    public GreaterOrLessController(IGreaterOrLessService greaterOrLessService)
    {
        _greaterOrLessService = greaterOrLessService;
    }

    [HttpPost]
    [Route("GreaterOrLess/{num1}/{num2}")]

    public string GreaterOrLess(string num1, string num2)
    {
        return _greaterOrLessService.GreaterOrLess(num1, num2);
    }

}
