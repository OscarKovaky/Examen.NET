using Dtos.BankDtos;
using Facade.BankFacade.Imp;
using Microsoft.AspNetCore.Mvc;

namespace Examen.NET.Controllers
{
    [Route("")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankFacade _logicFacade;

        public BankController(IBankFacade logicFacade)
        {
            _logicFacade = logicFacade ?? throw new ArgumentNullException(nameof(logicFacade));
        }

        [Route("createAccount")]
        [HttpPost]
        public async Task<bool> CreateAccount([FromQuery] int account, [FromQuery] int balance, [FromQuery] int owner)
        {
            return await _logicFacade.CreateAccount(account, balance, owner);
        }

        [Route("getAllAccounts")]
        [HttpGet]
        public async Task<List<AccountsDto>> GetAllAccounts()
        {
            return await _logicFacade.GetAllAccounts();
        }

        [Route("getAllAccountsOwner")]
        [HttpGet]
        public async Task<List<AccountsDto>> GetAllAccounts([FromQuery] int owner)
        {
            return await _logicFacade.GetAllAccounts(owner);
        }

        [Route("getAllTransaction")]
        [HttpGet]
        public async Task<List<TransactionDto>> GetAllTransaction()
        {
            return await _logicFacade.GetAllTransaction();
        }

        [Route("getAllTransactionFromAccount")]
        [HttpGet]
        public async Task<List<TransactionDto>> GetAllTransactionFromAccount([FromQuery] int fromAccount)
        {
            return await _logicFacade.GetAllTransactionFromAccount(fromAccount);
        }

        [Route("getAllTransactionToAccount")]
        [HttpGet]
        public async Task<List<TransactionDto>> GetAllTransactionToAccount([FromQuery] int toAccount)
        {
            return await _logicFacade.GetAllTransactionToAccount(toAccount);
        }

        [Route("getBalanceAccounts")]
        [HttpGet]
        public async Task<BalanceDto> GetBalanceAccounts([FromQuery] int NumberAccount)
        {
            return await _logicFacade.GetBalanceAccounts(NumberAccount);
        }
        [Route("createTransactionAccount")]
        [HttpPost]

        public async Task<bool> PostTransactionAccount([FromQuery] int fromAccount, [FromQuery] int toAccount, [FromQuery] double amount)
        {
            return await _logicFacade.PostTransactionAccount(fromAccount, toAccount, amount);
        }

    }
}
