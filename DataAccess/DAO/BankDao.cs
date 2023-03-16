using DataAccess.DAO.Imp;
using Entities.Context;
using Entities.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class BankDao : IBankDao
    {
        private readonly IDataBaseContext _databaseContext;

        public BankDao(IDataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<bool> CreateAccount(int account, int balance, int owner)
        {
            var newAccount = new Accounts() {
             Account = account,
             BalanceAccount= balance,
             Owner = owner,
             CreatedAt= DateTime.Now,
            };

            var newAccountBalance = new Balance()
            {
                Account = account,
                BalanceAccount = balance,
                Owner = owner,
                CreatedAt = DateTime.Now,
            };

            _databaseContext.Accounts.Add(newAccount);
            var result = await ((DataBaseContext)_databaseContext).SaveChangesAsync();

            _databaseContext.Balances.Add(newAccountBalance);

            await((DataBaseContext)_databaseContext).SaveChangesAsync();

            if (result > 0)
            {
                return true;
            }

            return false;

        }

        public async Task<List<Accounts>> GetAllAccounts()
        {
            var listAccounts = await _databaseContext.Accounts.ToListAsync();

            return listAccounts;
        }

        public async Task<List<Accounts>> GetAllAccounts(int owner)
        {
            var ownerAccount = await _databaseContext.Accounts.Where(e => e.Owner == owner).ToListAsync();

            return ownerAccount;
        }

        public async Task<List<Transaction>> GetAllTransaction()
        {
            var listTransactions = await _databaseContext.Transactions.ToListAsync();

            return listTransactions;
        }

        public async Task<List<Transaction>> GetAllTransactionFromAccount(int fromAccount)
        {
            var TransactionAccount = await _databaseContext.Transactions.Where(e => e.FromAccount == fromAccount).ToListAsync();

            return TransactionAccount;
        }

        public async Task<List<Transaction>> GetAllTransactionToAccount(int toAccount)
        {
            var TransactionAccount = await _databaseContext.Transactions.Where(e => e.ToAccount == toAccount).ToListAsync();

            return TransactionAccount;
        }

        public async Task<Balance> GetBalanceAccounts(int NumberAccount)
        {
            var BalanceAccount = await _databaseContext.Balances.Where(e => e.Account == NumberAccount).FirstAsync();

            return BalanceAccount;
        }

        public async Task<bool> PostTransactionAccount(int fromAccount, int toAccount, double amount)
        {
            var toAccountTransaction = await _databaseContext.Accounts.Where(e => e.Account == toAccount).FirstAsync();

            toAccountTransaction.BalanceAccount += amount;
            _databaseContext.Accounts.Update(toAccountTransaction);
            await ((DataBaseContext)_databaseContext).SaveChangesAsync();

            var transaction =  new Transaction()
            {
                FromAccount = fromAccount,
                ToAccount = toAccount,
                Amount = amount,
                SentAt= DateTime.Now,
            };

            _databaseContext.Transactions.Add(transaction);
            var result = await ((DataBaseContext)_databaseContext).SaveChangesAsync();

            if (result > 0 )
            {
                return true;
            }

            return false;
        }
    }
}
