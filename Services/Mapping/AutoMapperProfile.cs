using AutoMapper;
using Dtos.BankDtos;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {


            this.CreateMap<Accounts, AccountsDto>();
            this.CreateMap<AccountsDto, Accounts>();

            this.CreateMap<Balance, BalanceDto>();
            this.CreateMap<BalanceDto, Balance>();

            this.CreateMap<Transaction, TransactionDto>();
            this.CreateMap<TransactionDto, Transaction>();

        }
    }
}
