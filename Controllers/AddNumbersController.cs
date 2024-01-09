using ChinSMiniChallenge2_4.services.addnumbers;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge2_4.Controllers;

[ApiController]
[Route("controller")]
public class AddNumbersController : ControllerBase
{

    private readonly IAddNumbersService _addNumbersService;

    public AddNumbersController(IAddNumbersService addNumbersService)
    {
        _addNumbersService = addNumbersService;
    }


    [HttpPost]
    [Route("AddNumbers/{firstNumber}/{secondNumber}")]

    public string AddNumbers(string firstNumber, string secondNumber)
    {
        return _addNumbersService.AddNumbers(firstNumber, secondNumber);
    }

}
