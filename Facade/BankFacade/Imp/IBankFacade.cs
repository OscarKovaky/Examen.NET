using Dtos.BankDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.BankFacade.Imp
{
    public interface IBankFacade
    {
        Task<List<AccountsDto>> GetAllAccounts();

        Task<List<AccountsDto>> GetAllAccounts(int owner);


        Task<List<TransactionDto>> GetAllTransaction();

        Task<List<TransactionDto>> GetAllTransactionFromAccount(int fromAccount);


        Task<List<TransactionDto>> GetAllTransactionToAccount(int toAccount);

        Task<BalanceDto> GetBalanceAccounts(int NumberAccount);


        Task<bool> PostTransactionAccount(int fromAccount, int toAccount, double amount);

        Task<bool> CreateAccount(int account, int balance, int owner);
    }
}
