using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.Imp
{
    public interface IBankDao
    {
        Task<List<Accounts>> GetAllAccounts();

        Task<List<Accounts>> GetAllAccounts(int owner);


        Task<List<Transaction>> GetAllTransaction();

        Task<List<Transaction>> GetAllTransactionFromAccount(int fromAccount);


        Task<List<Transaction>> GetAllTransactionToAccount(int toAccount);

        Task<Balance> GetBalanceAccounts(int NumberAccount);


        Task<bool> PostTransactionAccount(int fromAccount, int toAccount, double amount);

        Task<bool> CreateAccount(int account, int balance, int owner);
    }
}
