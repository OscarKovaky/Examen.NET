using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class Transaction
    {
        [Key]
        [MaxLength(9, ErrorMessage = "Maximum number of characters that can be entered is 9!")]
        public int FromAccount  { get; set; }

        public int ToAccount { get; set; }

        public double Amount { get; set; }

        public DateTime SentAt { get; set; }
    }
}
