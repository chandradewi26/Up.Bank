using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Up.Bank.API.Controllers
{
    [Route ("up_banking/api/[controller]")]
    //https://localhost:44331/up_banking/api/Transactions
    // : = inherit
    public class TransactionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTransaction()
            //Could be OK result or Error result - 200 - 400 - HTTP Status
        {
            return Ok("Success!!");
        }




    }
    
}
