using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.View
{
    public class NXFCE100ResponseDTO
    {
        public string INTERID { get; set; }
        public short RMDTYPAL { get; set; }
        public string DOCNUMBR { get; set; }
        public string INVCNMBR { get; set; }
        public string BACHNUMB { get; set; }
        public string CustVenID { get; set; }
        public string CUSTNMBR { get; set; }
        public string CUSTNAME { get; set; }
        public string SHIPMTHD { get; set; }
        public string TAXSCHID { get; set; }
        public string SHRTNAME { get; set; }
        public string AccountSales { get; set; }
        public string AccountRecive { get; set; }
        public string AccountCost { get; set; }
        public string AccountProv { get; set; }
        public string AccountTrade { get; set; }
        public string NGOAccountCred { get; set; }
        public string NGOAccountDeb { get; set; }
        public string AccountIngFisticio { get; set; }
        public string AccountCosFisticio { get; set; }
        public string AccountElimicion { get; set; }
        public string DOCDESCR { get; set; }
        public string AADIMCHANEL { get; set; }
        public string AAPROJECT { get; set; }
        public string VALUEPROJECT { get; set; }
        public DateTime DOCDATE { get; set; }
        public decimal Total_Sales { get; set; }
        public string CURNCYID { get; set; }
        public string RATETPID { get; set; }
        public decimal APPLDAMT { get; set; }
        public DateTime APFRDCDT { get; set; }
        public string APFRDCNM { get; set; }
        public DateTime DATERECD { get; set; }
        public DateTime DATEDONE { get; set; }
        public short ERROR { get; set; }
        public short NUMOCPIS { get; set; }
        public int DEX_ROW_ID { get; set; }
    }
}
