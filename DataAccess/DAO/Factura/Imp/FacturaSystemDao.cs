using DataAccess.Utils;
using Dtos.View;
using Entities.Context;
using Entities.Models;
using Entities.Models.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.Factura.Imp
{
    public class FacturaSystemDao : IFacturaSystem
    {

        private readonly IDataBaseContext _databaseContext;


        public FacturaSystemDao(IDataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<NXFCE100> CrearFactura(NXFCE100Request request)
        {
            // Crear un nuevo objeto de tipo NXFCE100 con los datos de la nueva factura
            var nuevaFactura = new NXFCE100
            {
                INTERID = request.INTERID,
                RMDTYPAL = request.RMDTYPAL,
                DOCNUMBR = request.DOCNUMBR,
                INVCNMBR = request.INVCNMBR,
                BACHNUMB = request.BACHNUMB,
                CustVenID = request.CustVenID,
                CUSTNMBR = request.CUSTNMBR,
                CUSTNAME = request.CUSTNAME,
                SHIPMTHD = request.SHIPMTHD,
                TAXSCHID = request.TAXSCHID,
                SHRTNAME = request.SHRTNAME,
                AccountSales = request.AccountSales,
                AccountRecive = request.AccountRecive,
                AccountCost = request.AccountCost,
                AccountProv = request.AccountProv,
                AccountTrade = request.AccountTrade,
                NGOAccountCred = request.NGOAccountCred,
                NGOAccountDeb = request.NGOAccountDeb,
                AccountIngFisticio = request.AccountIngFisticio,
                AccountCosFisticio = request.AccountCosFisticio,
                AccountElimicion = request.AccountElimicion,
                DOCDESCR = request.DOCDESCR,
                AADIMCHANEL = request.AADIMCHANEL,
                AAPROJECT = request.AAPROJECT,
                VALUEPROJECT = request.VALUEPROJECT,
                DOCDATE = request.DOCDATE,
                Total_Sales = request.Total_Sales,
                CURNCYID = request.CURNCYID,
                RATETPID = request.RATETPID,
                APPLDAMT = request.APPLDAMT,
                APFRDCDT = request.APFRDCDT,
                APFRDCNM = request.APFRDCNM,
                DATERECD = request.DATERECD,
                DATEDONE = request.DATEDONE,
                ERROR = request.ERROR,
                NUMOCPIS = request.NUMOCPIS
            };

            // Agregar el objeto a la base de datos
            _databaseContext.NXFCE100s.Add(nuevaFactura);

            // Guardar los cambios en la base de datos
            await((DataBaseContext)_databaseContext).SaveChangesAsync();

            return nuevaFactura;
        }

        public async Task<NXFCE100> ObtenerDetalleFactura(string INTERID)
        {
            try
            {
                var factura = await _databaseContext.NXFCE100s.FirstOrDefaultAsync(f => f.INTERID == INTERID);

                if (factura == null)
                {
                    throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Factura no encontrada" });
                }

                var facturaModel = new NXFCE100
                {
                    INTERID = factura.INTERID,
                    RMDTYPAL = factura.RMDTYPAL,
                    DOCNUMBR = factura.DOCNUMBR,
                    INVCNMBR = factura.INVCNMBR,
                    BACHNUMB = factura.BACHNUMB,
                    CustVenID = factura.CustVenID,
                    CUSTNMBR = factura.CUSTNMBR,
                    CUSTNAME = factura.CUSTNAME,
                    SHIPMTHD = factura.SHIPMTHD,
                    TAXSCHID = factura.TAXSCHID,
                    SHRTNAME = factura.SHRTNAME,
                    AccountSales = factura.AccountSales,
                    AccountRecive = factura.AccountRecive,
                    AccountCost = factura.AccountCost,
                    AccountProv = factura.AccountProv,
                    AccountTrade = factura.AccountTrade,
                    NGOAccountCred = factura.NGOAccountCred,
                    NGOAccountDeb = factura.NGOAccountDeb,
                    AccountIngFisticio = factura.AccountIngFisticio,
                    AccountCosFisticio = factura.AccountCosFisticio,
                    AccountElimicion = factura.AccountElimicion,
                    DOCDESCR = factura.DOCDESCR,
                    AADIMCHANEL = factura.AADIMCHANEL,
                    AAPROJECT = factura.AAPROJECT,
                    VALUEPROJECT = factura.VALUEPROJECT,
                    DOCDATE = factura.DOCDATE,
                    Total_Sales = factura.Total_Sales,
                    CURNCYID = factura.CURNCYID,
                    RATETPID = factura.RATETPID,
                    APPLDAMT = factura.APPLDAMT,
                    APFRDCDT = factura.APFRDCDT,
                    APFRDCNM = factura.APFRDCNM,
                    DATERECD = factura.DATERECD,
                    DATEDONE = factura.DATEDONE,
                    ERROR = factura.ERROR,
                    NUMOCPIS = factura.NUMOCPIS
                };

                return facturaModel;
            }
            catch (Exception ex)
            {
                // Manejar el error de alguna manera (p. ej., loguearlo)
                throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Factura no encontrada" });
            }
        }

        public async Task<List<NXFCE100>> ObtenerTodasLasFacturas()
        {
            var facturas = await _databaseContext.NXFCE100s.ToListAsync();

            return facturas;

        }

        public async Task<List<NXFCE102>> ObtenerTodosLosImpuestos()
        {
            // Obtener todos los impuestos almacenados en la tabla NXFCE102
            var impuestos = await _databaseContext.NXFCE102s.ToListAsync();

            return impuestos;
        }

        public async Task<NXFCE100> UpdateFactura(ActualizarNXFCE100DTO datosActualizados)
        {
            // Buscar la factura en la base de datos por su ID
            var factura = _databaseContext.NXFCE100s.SingleOrDefault(f => f.DOCNUMBR == datosActualizados.DOCNUMBR);

            // Verificar si la factura existe
            if (factura == null)
            {
                throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Factura no encontrada" });
            }

            // Actualizar los campos de la factura con los datos proporcionados
            factura.INVCNMBR = datosActualizados.INVCNMBR;
            factura.BACHNUMB = datosActualizados.BACHNUMB;
            factura.CustVenID = datosActualizados.CustVenID;
            factura.CUSTNMBR = datosActualizados.CUSTNMBR;
            factura.CUSTNAME = datosActualizados.CUSTNAME;
            factura.SHIPMTHD = datosActualizados.SHIPMTHD;
            factura.TAXSCHID = datosActualizados.TAXSCHID;
            factura.SHRTNAME = datosActualizados.SHRTNAME;
            factura.AccountSales = datosActualizados.AccountSales;
            factura.AccountRecive = datosActualizados.AccountRecive;
            factura.AccountCost = datosActualizados.AccountCost;
            factura.AccountProv = datosActualizados.AccountProv;
            factura.AccountTrade = datosActualizados.AccountTrade;
            factura.NGOAccountCred = datosActualizados.NGOAccountCred;
            factura.NGOAccountDeb = datosActualizados.NGOAccountDeb;
            factura.AccountIngFisticio = datosActualizados.AccountIngFisticio;
            factura.AccountCosFisticio = datosActualizados.AccountCosFisticio;
            factura.AccountElimicion = datosActualizados.AccountElimicion;
            factura.DOCDESCR = datosActualizados.DOCDESCR;
            factura.AADIMCHANEL = datosActualizados.AADIMCHANEL;
            factura.AAPROJECT = datosActualizados.AAPROJECT;
            factura.VALUEPROJECT = datosActualizados.VALUEPROJECT;
            factura.DOCDATE = datosActualizados.DOCDATE;
            factura.Total_Sales = datosActualizados.Total_Sales;
            factura.CURNCYID = datosActualizados.CURNCYID;
            factura.RATETPID = datosActualizados.RATETPID;
            factura.APPLDAMT = datosActualizados.APPLDAMT;
            factura.APFRDCDT = datosActualizados.APFRDCDT;
            factura.APFRDCNM = datosActualizados.APFRDCNM;
            factura.DATERECD = datosActualizados.DATERECD;
            factura.DATEDONE = datosActualizados.DATEDONE;
            factura.ERROR = datosActualizados.ERROR;
            factura.NUMOCPIS = datosActualizados.NUMOCPIS;
            // El campo DEX_ROW_ID es una columna IDENTITY en la base de datos y no debe actualizarse

            // Guardar los cambios en la base de datos
            await((DataBaseContext)_databaseContext).SaveChangesAsync();

            // Devolver fatura actualizada
            return factura;
        }

        public async Task<string> UpdateImpuesto(ImpuestoUpdateModelDto requestImpuestoUpdateModelDto)
        {

            // Buscar el impuesto en la base de datos utilizando las claves primarias
            var impuesto = _databaseContext.NXFCE102s.FirstOrDefault(i =>
                i.INTERID == requestImpuestoUpdateModelDto.INTERID &&
                i.RMDTYPAL == requestImpuestoUpdateModelDto.RMDTYPAL &&
                i.DOCNUMBR == requestImpuestoUpdateModelDto.DOCNUMBR &&
                i.TAXDTLID == requestImpuestoUpdateModelDto.TAXDTLID);

            // Obtener el porcentaje anterior del impuesto
            decimal porcentajeAnterior = impuesto.TAXAMNT / impuesto.TAXDTSLS;

            // Actualizar el porcentaje del impuesto
            impuesto.TAXAMNT = requestImpuestoUpdateModelDto.NuevoPorcentaje * impuesto.TAXDTSLS;

            // Realizar el recálculo de impuestos si es necesario (según la lógica específica de tu sistema)
            if (impuesto.TAXAMNT != porcentajeAnterior)
            {
                // Supongamos que el impuesto se identifica por su TAXDTLID
                var taxDetailId = impuesto.TAXDTLID;

                // Obtenemos todas las facturas que contienen este impuesto específico
                var facturasConImpuesto = _databaseContext.NXFCE100s
                    .Where(f => _databaseContext.NXFCE102s
                        .Any(i => i.INTERID == f.INTERID &&
                                  i.RMDTYPAL == f.RMDTYPAL &&
                                  i.DOCNUMBR == f.DOCNUMBR &&
                                  i.TAXDTLID == taxDetailId))
                    .ToList();

                foreach (var factura in facturasConImpuesto)
                {
                    // Obtenemos el impuesto asociado a la factura
                    var impuestoFactura = _databaseContext.NXFCE102s
                        .FirstOrDefault(i =>
                            i.INTERID == factura.INTERID &&
                            i.RMDTYPAL == factura.RMDTYPAL &&
                            i.DOCNUMBR == factura.DOCNUMBR &&
                            i.TAXDTLID == impuesto.TAXDTLID);

                    // Verificamos si el impuesto existe y ha sido actualizado
                    if (impuestoFactura != null && impuestoFactura.TAXAMNT != porcentajeAnterior)
                    {
                        // Realizamos el recálculo del impuesto para la factura
                        impuestoFactura.TAXAMNT = impuesto.TAXAMNT * factura.Total_Sales;

                        // Guardamos los cambios en la base de datos
                        try
                        {
                            await((DataBaseContext)_databaseContext).SaveChangesAsync();
                            return "Actualizada Correctamente";
                        }
                        catch (Exception ex)
                        {
                            throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Error al recalcular el impuesto para la factura. Detalles del error: " });
                        }
                    }
                }
             

            }

            return "Recalculo de impuestos (sólo si el porcentaje del impuesto es actualizado) Error";
        }
    }
}
