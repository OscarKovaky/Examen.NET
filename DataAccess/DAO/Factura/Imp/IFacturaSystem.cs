using Dtos;
using Dtos.View;
using Entities.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.Factura.Imp
{
    public  interface IFacturaSystem
    {
        Task<string> UpdateImpuesto(ImpuestoUpdateModelDto requestImpuestoUpdateModelDto);

        Task<NXFCE100> UpdateFactura(ActualizarNXFCE100DTO datosActualizados);

        Task<NXFCE100> CrearFactura(NXFCE100Request request);

        Task<List<NXFCE100>> ObtenerTodasLasFacturas();

        Task<List<NXFCE102>> ObtenerTodosLosImpuestos();

        Task<NXFCE100> ObtenerDetalleFactura(string INTERID);


    }
}
