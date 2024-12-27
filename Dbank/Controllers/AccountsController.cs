using Microsoft.AspNetCore.Mvc;
using Dbank.Models;

namespace Dbank.Controllers;

[Route("api/accounts")]
public class AccountsController : BaseApiContoller
{
    [HttpGet("welcome")]
    public IActionResult Get()
    {
        return Ok("Добро пожаловать в Dbank!");
    }

    [HttpGet("partner")]
    public IActionResult Get2()
    {
        return Ok("Dbank - Ваш надёжный партнёр в финансовом мире, " +
                  "где ваши цели становятся реальностью.");
    }

    [HttpPost("authorization")]
    public IActionResult Post(AccountsClass account)
    {
        if (account.AccountLogin.Length == 11 &
            account.AccountPassword.Length == 3)
        {
            return Ok("Авторизация прошла успешно!");
        }
        return BadRequest("Неподходящий формат, проверьте логин и пароль.");
        
    }

    [HttpPost("authentication")]
    public IActionResult Post2(AccountsClass account)
    {
        if (account.AccountLogin == "89511105288" &
            account.AccountPassword == "123")
        {
            return Ok("Аутентификация прошла успешна!");
        }
        return BadRequest("Неверный логин или пароль, попробуйте еще раз.");
    }
}
