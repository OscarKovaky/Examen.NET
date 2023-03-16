using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.BankDtos
{
    public class BalanceDto
    {
        public int Account { get; set; }

        public int BalanceAccount { get; set; }

        public int Owner { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
