
using Dtos.BankDtos;
using Facade.BankFacade.Imp;
using Services.BankService.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.BankFacade
{
    public class BankFacade : IBankFacade
    {
        private readonly IBankService _bankService;

        public BankFacade(IBankService bankService)
        {
            _bankService = bankService;
        }
        public async Task<bool> CreateAccount(int account, int balance, int owner)
        {
            return await _bankService.CreateAccount(account, balance, owner);
        }

        public async Task<List<AccountsDto>> GetAllAccounts()
        {
            return await _bankService.GetAllAccounts();
        }

        public async Task<List<AccountsDto>> GetAllAccounts(int owner)
        {
            return await _bankService.GetAllAccounts(owner);
        }

        public async Task<List<TransactionDto>> GetAllTransaction()
        {
            return await _bankService.GetAllTransaction();
        }

        public async Task<List<TransactionDto>> GetAllTransactionFromAccount(int fromAccount)
        {
            return await _bankService.GetAllTransactionFromAccount(fromAccount);
        }

        public async Task<List<TransactionDto>> GetAllTransactionToAccount(int toAccount)
        {
            return await _bankService.GetAllTransactionToAccount(toAccount);
        }

        public async Task<BalanceDto> GetBalanceAccounts(int NumberAccount)
        {
            return await _bankService.GetBalanceAccounts(NumberAccount);
        }

        public async Task<bool> PostTransactionAccount(int fromAccount, int toAccount, double amount)
        {
            return await _bankService.PostTransactionAccount(fromAccount, toAccount, amount);
        }
    }
}
