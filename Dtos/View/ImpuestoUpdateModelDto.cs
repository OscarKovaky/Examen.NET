using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.View
{
    public class ImpuestoUpdateModelDto
    {
        public string INTERID { get; set; }
        public int RMDTYPAL { get; set; }
        public string DOCNUMBR { get; set; }
        public string TAXDTLID { get; set; }
        public decimal NuevoPorcentaje { get; set; }
    }
}
