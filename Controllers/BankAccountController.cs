using BankingApp.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BankingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankAccountController : ControllerBase
    {
        private readonly DataService _dataService;

        public BankAccountController(DataService dataService)
        {
            _dataService = dataService;
        }

        [SwaggerOperation(Summary = "Get the balance of the account")]
        [HttpGet]
        public IActionResult Get()
        {
            var response = $"{_dataService.Customer.FirstName}'s account ({_dataService.Account.AccountState}) balance: {_dataService.Account.Balance}";
            return Ok(response);
        }

        [SwaggerOperation(Summary = "Deposit or withdraw money")]
        [HttpPost]
        public IActionResult Put(int amount)
        {
            if (amount > 0) _dataService.Account.AccountState.Deposit(amount);
            else _dataService.Account.AccountState.Withdraw(Math.Abs(amount));
            var response = $"{_dataService.Customer.FirstName}'s account ({_dataService.Account.AccountState}) new balance: {_dataService.Account.Balance}";
            return Ok(response);
        }

        [SwaggerOperation(Summary = "Freeze the account (by the bank)")]
        [HttpDelete]
        public IActionResult Delete()
        {
            _dataService.Account.Freeze();
            var response = $"{_dataService.Customer.FirstName}'s account ({_dataService.Account.AccountState}) new balance: {_dataService.Account.Balance}";
            return Ok(response);
        }
    }
}