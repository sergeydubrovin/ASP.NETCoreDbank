using Microsoft.AspNetCore.Mvc;

namespace Dbank.Controllers;

[Route("api/balances")]
public class BalancesController : BaseApiContoller
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
