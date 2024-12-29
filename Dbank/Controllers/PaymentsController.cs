using Dbank.Models;
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

    [HttpPost("transaction")]
    public IActionResult Post(PaymentsClass pay)
    {
        if(pay.TransferAddress.Length == 11) 
           return Ok(pay);

        return BadRequest("Неверные данные получателя.");
    }

    [HttpPost("post2")]
    public IActionResult Post2()
    {
        return Ok();
    }
}
