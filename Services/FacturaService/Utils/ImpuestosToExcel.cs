using ClosedXML.Excel;
using Dtos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FacturaService.Utils
{
    public static class ImpuestosToExcel
    {
        public static byte[] ConvertExcelNXFCE102(List<NXFCE102ResponseDTO> list)
        {
            using (IXLWorkbook workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Impuestos NXFCE102");
                var currentRow = 1;

                worksheet.Cell(currentRow, 1).Value = "INTERID";
                worksheet.Cell(currentRow, 2).Value = "RMDTYPAL";
                worksheet.Cell(currentRow, 3).Value = "DOCNUMBR";
                worksheet.Cell(currentRow, 4).Value = "INVCNMBR";
                worksheet.Cell(currentRow, 5).Value = "TAXDTLID";
                worksheet.Cell(currentRow, 6).Value = "TAXAMNT";
                worksheet.Cell(currentRow, 7).Value = "STAXAMNT";
                worksheet.Cell(currentRow, 8).Value = "TAXDTSLS";
                worksheet.Cell(currentRow, 9).Value = "ProductGroup";
                worksheet.Cell(currentRow, 10).Value = "IdBookingLine";
                worksheet.Cell(currentRow, 11).Value = "ACTNUMST";

                for (int i = 1; i <= 9; i++)
                {
                    var column = worksheet.Column(i);
                    column.Width = 15;
                }

                var range = worksheet.Range("A1:I1");
                range.Style.Fill.BackgroundColor = XLColor.BlueGray;
                range.Style.Font.FontColor = XLColor.White;
                range.RangeUsed().SetAutoFilter().Column(2);

                foreach (var impuesto in list)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = impuesto.INTERID;
                    worksheet.Cell(currentRow, 2).Value = impuesto.RMDTYPAL;
                    worksheet.Cell(currentRow, 3).Value = impuesto.DOCNUMBR;
                    worksheet.Cell(currentRow, 4).Value = impuesto.INVCNMBR;
                    worksheet.Cell(currentRow, 5).Value = impuesto.TAXDTLID;
                    worksheet.Cell(currentRow, 6).Value = impuesto.TAXAMNT;
                    worksheet.Cell(currentRow, 7).Value = impuesto.STAXAMNT;
                    worksheet.Cell(currentRow, 8).Value = impuesto.TAXDTSLS;
                    worksheet.Cell(currentRow, 9).Value = impuesto.ProductGroup;
                    worksheet.Cell(currentRow, 10).Value = impuesto.IdBookingLine;
                    worksheet.Cell(currentRow, 11).Value = impuesto.ACTNUMST;

                    // Ajustar el ancho de las columnas automáticamente según el contenido
                    for (int i = 1; i <= 9; i++)
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
