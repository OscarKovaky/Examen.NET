using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.BankDtos
{
    public class TransactionDto
    {
        public int FromAccount { get; set; }

        public int ToAccount { get; set; }

        public double Amount { get; set; }

        public DateTime SentAt { get; set; }
    }
}
