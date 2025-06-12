using curso_c_.API.UseCases.Clients.Register;
using curso_rocket.Communication.Requests;
using curso_rocket.Communication.Response;
using Microsoft.AspNetCore.Mvc;

namespace curso_c_.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    [HttpPost]

    [ProducesResponseType(typeof(ResposeClientJson), StatusCodes.Status201Created)]

    [ProducesResponseType(typeof(ErrorMessageJson), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] ClientsRequestJson request)
    {
        var useCase = new RegisterClientUseCase();

        var response = useCase.Execute(request);

        return Created(string.Empty, response);
    }

    [HttpPut]
    public IActionResult Update()
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetById([FromBody] Guid id)
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult Delete()
    {
        return Ok();
    }
}
