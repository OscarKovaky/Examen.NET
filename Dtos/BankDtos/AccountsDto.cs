using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.BankDtos
{
    public class AccountsDto
    {
        public int Account { get; set; }

        public double BalanceAccount { get; set; }

        public int Owner { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
