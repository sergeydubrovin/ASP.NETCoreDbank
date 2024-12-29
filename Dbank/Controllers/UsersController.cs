using Dbank.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dbank.Controllers;

[Route("api/users")]
public class UsersController : BaseApiContoller
{
    [HttpGet("id")]
    public IActionResult Get()
    {
        return Ok(UsersClass.Id);
    }

    [HttpGet("passportinfo")]
    public IActionResult Get2(string message)
    {
        if(message.Equals("Серия и номер паспорта",
           StringComparison.OrdinalIgnoreCase))
        return Ok(UsersClass.Passport);

        return BadRequest();
    }

    [HttpPost("userinfo")]
    public IActionResult Post(UsersClass user)
    {
        if (user.CardNumber.Length == 16)
            return Ok(user);
        
        return BadRequest("Неправильный формат номера карты.");
    }

    [HttpPost("post2")]
    public IActionResult Post2()
    {
        return Ok();
    }
}
