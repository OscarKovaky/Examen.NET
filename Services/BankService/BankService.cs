using AutoMapper;
using DataAccess.DAO.Imp;
using Dtos.BankDtos;
using Services.BankService.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Services.BankService
{
    public class BankService : IBankService
    {
        private readonly IMapper _mapper;
        private readonly IBankDao _modelDao;


        public BankService(IMapper mapper, IBankDao modelDao)
        {
            _mapper = mapper;
            _modelDao = modelDao;
        }
        public async Task<bool> CreateAccount(int account, int balance, int owner)
        {
            return await _modelDao.CreateAccount(account, balance, owner);
        }

        public async Task<List<AccountsDto>> GetAllAccounts()
        {
            return _mapper.Map<List<AccountsDto>>(await _modelDao.GetAllAccounts());
        }

        public  async Task<List<AccountsDto>> GetAllAccounts(int owner)
        {
            return _mapper.Map<List<AccountsDto>>(await _modelDao.GetAllAccounts(owner));
        }

        public async Task<List<TransactionDto>> GetAllTransaction()
        {
            return _mapper.Map<List<TransactionDto>>(await _modelDao.GetAllTransaction());
        }

        public async Task<List<TransactionDto>> GetAllTransactionFromAccount(int fromAccount)
        {
            return _mapper.Map<List<TransactionDto>>(await _modelDao.GetAllTransactionFromAccount(fromAccount));
        }

        public async Task<List<TransactionDto>> GetAllTransactionToAccount(int toAccount)
        {
            return _mapper.Map<List<TransactionDto>>(await _modelDao.GetAllTransactionToAccount(toAccount));
        }

        public async Task<BalanceDto> GetBalanceAccounts(int NumberAccount)
        {
            return _mapper.Map<BalanceDto>(await _modelDao.GetBalanceAccounts(NumberAccount));
        }

        public async Task<bool> PostTransactionAccount(int fromAccount, int toAccount, double amount)
        {
            return await _modelDao.PostTransactionAccount(fromAccount, toAccount, amount);
        }
    }
}
