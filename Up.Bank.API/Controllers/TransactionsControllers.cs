using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Up.Bank.BusinessLogic.Logic;

namespace Up.Bank.API.Controllers
{
    [Route ("up_banking/api/[controller]")]
    //https://localhost:44331/up_banking/api/Transactions
    // : = inherit
    public class TransactionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTransaction()
            //Could be OK result or Error result - 200 - 404 500 - HTTP Status
        {
            var _TransactionLogic = new TransactionLogic();
            //_TransactionLogic.GetNewTransaction();


            return Ok(_TransactionLogic.GetNewTransaction());

        }
        // Have to do homework
        // For Account, domain model account, account logic, account controller,

    }
    
}
