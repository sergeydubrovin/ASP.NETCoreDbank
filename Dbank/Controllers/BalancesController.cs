using Dbank.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dbank.Controllers;

[Route("api/balances")]
public class BalancesController : BaseApiContoller
{
    [HttpGet("balance")]
    public IActionResult Get(string message)
    {
        if(message.Equals("мой баланс", 
                          StringComparison.OrdinalIgnoreCase))
          return Ok(BalancesClass.Format());

        return BadRequest();
    }

    [HttpGet("writeoffs")]
    public IActionResult Get2(string message)
    {
        if(message.Equals("история списаний и начислений", 
                          StringComparison.OrdinalIgnoreCase))
          return Ok(BalancesClass.Writeoffs);
        
        return BadRequest();
    }

    [HttpPost("depositcalc")]
    public IActionResult Post(uint period, decimal depositAmount)
    {   
        return Ok(BalancesClass.CalcAmount(period, depositAmount));
    }

    [HttpPost("currencyconverter")]
    public IActionResult Post2()
    {
        return Ok(BalancesClass.CurrencyConverter());
    }
}
