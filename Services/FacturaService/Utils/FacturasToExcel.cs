using ClosedXML.Excel;
using Dtos.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FacturaService.Utils
{
    public static class FacturasToExcel
    {
        public static byte[] ConvertExcelNXFCE100(List<NXFCE100ResponseDTO> list)
        {
            using (IXLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Facturas NXFCE100");
                var currentRow = 1;

                worksheet.Cell(currentRow, 1).Value = "INTERID";
                worksheet.Cell(currentRow, 2).Value = "RMDTYPAL";
                worksheet.Cell(currentRow, 3).Value = "DOCNUMBR";
                worksheet.Cell(currentRow, 4).Value = "INVCNMBR";
                worksheet.Cell(currentRow, 5).Value = "BACHNUMB";
                worksheet.Cell(currentRow, 6).Value = "CustVenID";
                worksheet.Cell(currentRow, 7).Value = "CUSTNMBR";
                worksheet.Cell(currentRow, 8).Value = "CUSTNAME";
                worksheet.Cell(currentRow, 9).Value = "SHIPMTHD";
                worksheet.Cell(currentRow, 10).Value = "TAXSCHID";
                worksheet.Cell(currentRow, 11).Value = "SHRTNAME";
                worksheet.Cell(currentRow, 12).Value = "AccountSales";
                worksheet.Cell(currentRow, 13).Value = "AccountRecive";
                worksheet.Cell(currentRow, 14).Value = "AccountCost";
                worksheet.Cell(currentRow, 15).Value = "AccountProv";
                worksheet.Cell(currentRow, 16).Value = "AccountTrade";
                worksheet.Cell(currentRow, 17).Value = "NGOAccountCred";
                worksheet.Cell(currentRow, 18).Value = "NGOAccountDeb";
                worksheet.Cell(currentRow, 19).Value = "AccountIngFisticio";
                worksheet.Cell(currentRow, 20).Value = "AccountCosFisticio";
                worksheet.Cell(currentRow, 21).Value = "AccountElimicion";
                worksheet.Cell(currentRow, 22).Value = "DOCDESCR";
                worksheet.Cell(currentRow, 23).Value = "AADIMCHANEL";
                worksheet.Cell(currentRow, 24).Value = "AAPROJECT";
                worksheet.Cell(currentRow, 25).Value = "VALUEPROJECT";
                worksheet.Cell(currentRow, 26).Value = "DOCDATE";
                worksheet.Cell(currentRow, 27).Value = "Total_Sales";
                worksheet.Cell(currentRow, 28).Value = "CURNCYID";
                worksheet.Cell(currentRow, 29).Value = "RATETPID";
                worksheet.Cell(currentRow, 30).Value = "APPLDAMT";
                worksheet.Cell(currentRow, 31).Value = "APFRDCDT";
                worksheet.Cell(currentRow, 32).Value = "APFRDCNM";
                worksheet.Cell(currentRow, 33).Value = "DATERECD";
                worksheet.Cell(currentRow, 34).Value = "DATEDONE";
                worksheet.Cell(currentRow, 35).Value = "ERROR";
                worksheet.Cell(currentRow, 36).Value = "NUMOCPIS";
                worksheet.Cell(currentRow, 37).Value = "DEX_ROW_ID";

                for (int i = 1; i <= 37; i++)
                {
                    var column = worksheet.Column(i);
                    column.Width = 15;
                }

                var range = worksheet.Range("A1:AK1");
                range.Style.Fill.BackgroundColor = XLColor.BlueGray;
                range.Style.Font.FontColor = XLColor.White;
                range.RangeUsed().SetAutoFilter().Column(2);

                foreach (var factura in list)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = factura.INTERID;
                    worksheet.Cell(currentRow, 2).Value = factura.RMDTYPAL;
                    worksheet.Cell(currentRow, 3).Value = factura.DOCNUMBR;
                    worksheet.Cell(currentRow, 4).Value = factura.INVCNMBR;
                    worksheet.Cell(currentRow, 5).Value = factura.BACHNUMB;
                    worksheet.Cell(currentRow, 6).Value = factura.CustVenID;
                    worksheet.Cell(currentRow, 7).Value = factura.CUSTNMBR;
                    worksheet.Cell(currentRow, 8).Value = factura.CUSTNAME;
                    worksheet.Cell(currentRow, 9).Value = factura.SHIPMTHD;
                    worksheet.Cell(currentRow, 10).Value = factura.TAXSCHID;
                    worksheet.Cell(currentRow, 11).Value = factura.SHRTNAME;
                    worksheet.Cell(currentRow, 12).Value = factura.AccountSales;
                    worksheet.Cell(currentRow, 13).Value = factura.AccountRecive;
                    worksheet.Cell(currentRow, 14).Value = factura.AccountCost;
                    worksheet.Cell(currentRow, 15).Value = factura.AccountProv;
                    worksheet.Cell(currentRow, 16).Value = factura.AccountTrade;
                    worksheet.Cell(currentRow, 17).Value = factura.NGOAccountCred;
                    worksheet.Cell(currentRow, 18).Value = factura.NGOAccountDeb;
                    worksheet.Cell(currentRow, 19).Value = factura.AccountIngFisticio;
                    worksheet.Cell(currentRow, 20).Value = factura.AccountCosFisticio;
                    worksheet.Cell(currentRow, 21).Value = factura.AccountElimicion;
                    worksheet.Cell(currentRow, 22).Value = factura.DOCDESCR;
                    worksheet.Cell(currentRow, 23).Value = factura.AADIMCHANEL;
                    worksheet.Cell(currentRow, 24).Value = factura.AAPROJECT;
                    worksheet.Cell(currentRow, 25).Value = factura.VALUEPROJECT;
                    worksheet.Cell(currentRow, 26).Value = factura.DOCDATE;
                    worksheet.Cell(currentRow, 27).Value = factura.Total_Sales;
                    worksheet.Cell(currentRow, 28).Value = factura.CURNCYID;
                    worksheet.Cell(currentRow, 29).Value = factura.RATETPID;
                    worksheet.Cell(currentRow, 30).Value = factura.APPLDAMT;
                    worksheet.Cell(currentRow, 31).Value = factura.APFRDCDT;
                    worksheet.Cell(currentRow, 32).Value = factura.APFRDCNM;
                    worksheet.Cell(currentRow, 33).Value = factura.DATERECD;
                    worksheet.Cell(currentRow, 34).Value = factura.DATEDONE;
                    worksheet.Cell(currentRow, 35).Value = factura.ERROR;
                    worksheet.Cell(currentRow, 36).Value = factura.NUMOCPIS;
                    worksheet.Cell(currentRow, 37).Value = factura.DEX_ROW_ID;

                    // Ajustar el ancho de las columnas automáticamente según el contenido
                    for (int i = 1; i <= 37; i++)
                    {
                        worksheet.Column(i).AdjustToContents();
                    }
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return content;
                }
            }
        }
    }
}
