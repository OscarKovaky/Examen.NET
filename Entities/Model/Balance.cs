using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Balance
    {
        [Key]
        public int Account { get; set; }

        public int BalanceAccount { get; set; }

        public int Owner { get; set; }

        public DateTime CreatedAt { get; set; }


    }
}
