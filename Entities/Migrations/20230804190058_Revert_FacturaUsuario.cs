using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    public partial class Revert_FacturaUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.CreateTable(
                name: "NXFCE100",
                columns: table => new
                {
                    INTERID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    RMDTYPAL = table.Column<short>(type: "smallint", nullable: false),
                    DOCNUMBR = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    INVCNMBR = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    BACHNUMB = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CustVenID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CUSTNMBR = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CUSTNAME = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    SHIPMTHD = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TAXSCHID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    SHRTNAME = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    AccountSales = table.Column<string>(type: "nvarchar(129)", maxLength: 129, nullable: false),
                    AccountRecive = table.Column<string>(type: "nvarchar(129)", maxLength: 129, nullable: false),
                    AccountCost = table.Column<string>(type: "nvarchar(129)", maxLength: 129, nullable: false),
                    AccountProv = table.Column<string>(type: "nvarchar(129)", maxLength: 129, nullable: false),
                    AccountTrade = table.Column<string>(type: "nvarchar(129)", maxLength: 129, nullable: false),
                    NGOAccountCred = table.Column<string>(type: "nvarchar(129)", maxLength: 129, nullable: false),
                    NGOAccountDeb = table.Column<string>(type: "nvarchar(129)", maxLength: 129, nullable: false),
                    AccountIngFisticio = table.Column<string>(type: "nvarchar(129)", maxLength: 129, nullable: false),
                    AccountCosFisticio = table.Column<string>(type: "nvarchar(129)", maxLength: 129, nullable: false),
                    AccountElimicion = table.Column<string>(type: "nvarchar(129)", maxLength: 129, nullable: false),
                    DOCDESCR = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    AADIMCHANEL = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    AAPROJECT = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    VALUEPROJECT = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    DOCDATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total_Sales = table.Column<decimal>(type: "numeric(19,5)", nullable: false),
                    CURNCYID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    RATETPID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    APPLDAMT = table.Column<decimal>(type: "numeric(19,5)", nullable: false),
                    APFRDCDT = table.Column<DateTime>(type: "datetime2", nullable: false),
                    APFRDCNM = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    DATERECD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DATEDONE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ERROR = table.Column<short>(type: "smallint", nullable: false),
                    NUMOCPIS = table.Column<short>(type: "smallint", nullable: false),
                    DEX_ROW_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NXFCE100", x => x.INTERID);
                });

            migrationBuilder.CreateTable(
                name: "NXFCE101",
                columns: table => new
                {
                    IdBookingLine = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    INTERID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    RMDTYPAL = table.Column<short>(type: "smallint", nullable: false),
                    DOCNUMBR = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    INVCNMBR = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    BookingCode = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    CMPNYNUM = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ProductGroup = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    PaxNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DOCAMNT = table.Column<decimal>(type: "numeric(19,5)", nullable: false),
                    COMMAMNT = table.Column<decimal>(type: "numeric(19,5)", nullable: false),
                    ExSLCode = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    AnalyticCode = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    Client = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    CURNCYID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ExtPurchCode = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    ExSaCoMCod = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    TOTALPAY = table.Column<decimal>(type: "numeric(19,5)", nullable: false),
                    AMNTPAID = table.Column<decimal>(type: "numeric(19,5)", nullable: false),
                    Amount_Received = table.Column<decimal>(type: "numeric(19,5)", nullable: false),
                    REFRENCE = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    TRDISAMT = table.Column<decimal>(type: "numeric(19,5)", nullable: false),
                    DEX_ROW_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NXFCE101", x => x.IdBookingLine);
                });

            migrationBuilder.CreateTable(
                name: "NXFCE102",
                columns: table => new
                {
                    IdBookingLine = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    INTERID = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    RMDTYPAL = table.Column<short>(type: "smallint", nullable: false),
                    DOCNUMBR = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    INVCNMBR = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    TAXDTLID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    TAXAMNT = table.Column<decimal>(type: "numeric(19,5)", nullable: false),
                    STAXAMNT = table.Column<decimal>(type: "numeric(19,5)", nullable: false),
                    TAXDTSLS = table.Column<decimal>(type: "numeric(19,5)", nullable: false),
                    ProductGroup = table.Column<string>(type: "nvarchar(31)", maxLength: 31, nullable: false),
                    ACTNUMST = table.Column<string>(type: "nvarchar(129)", maxLength: 129, nullable: false),
                    DEX_ROW_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NXFCE102", x => x.IdBookingLine);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NXFCE100");

            migrationBuilder.DropTable(
                name: "NXFCE101");

            migrationBuilder.DropTable(
                name: "NXFCE102");

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApellidoMaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.FacturaId);
                    table.ForeignKey(
                        name: "FK_Facturas_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_PersonaId",
                table: "Facturas",
                column: "PersonaId");
        }
    }
}
