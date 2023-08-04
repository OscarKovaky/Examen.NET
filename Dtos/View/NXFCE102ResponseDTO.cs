using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.View
{
    public class NXFCE102ResponseDTO
    {
        public string INTERID { get; set; }
        public short RMDTYPAL { get; set; }
        public string DOCNUMBR { get; set; }
        public string INVCNMBR { get; set; }
        public string TAXDTLID { get; set; }
        public decimal TAXAMNT { get; set; }
        public decimal STAXAMNT { get; set; }
        public decimal TAXDTSLS { get; set; }
        public string ProductGroup { get; set; }
        public string IdBookingLine { get; set; }
        public string ACTNUMST { get; set; }
        public int DEX_ROW_ID { get; set; }
    }
}
