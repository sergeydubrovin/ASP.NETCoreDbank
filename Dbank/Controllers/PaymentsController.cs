using Microsoft.AspNetCore.Mvc;

namespace Dbank.Controllers;

[Route("api/payments")]
public class PaymentsController : BaseApiContoller
{
    [HttpGet("get")]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpGet("get2")]
    public IActionResult Get2()
    {
        return Ok();
    }

    [HttpPost("post")]
    public IActionResult Post()
    {
        return Ok();
    }

    [HttpPost("post2")]
    public IActionResult Post2()
    {
        return Ok();
    }
}
