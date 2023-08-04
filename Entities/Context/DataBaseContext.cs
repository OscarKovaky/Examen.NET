
using Entities.Models;
using Entities.Models.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
{
    public class DataBaseContext:  IdentityDbContext<Cliente>, IDataBaseContext
    {
     
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
             
        }

        public DbSet<NXFCE100> NXFCE100s { get; set; }
        public DbSet<NXFCE101> NXFCE101s { get; set; }
        public DbSet<NXFCE102> NXFCE102s { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<NXFCE102>(entity =>
            {
                entity.ToTable("NXFCE102");

                entity.HasKey(e => e.IdBookingLine);

                entity.Property(e => e.IdBookingLine)
                    .HasColumnName("IdBookingLine")
                    .HasMaxLength(31)
                    .IsRequired();

                entity.Property(e => e.INTERID)
                    .HasColumnName("INTERID")
                    .HasMaxLength(5)
                    .IsRequired();

                entity.Property(e => e.RMDTYPAL)
                    .HasColumnName("RMDTYPAL")
                    .IsRequired();

                entity.Property(e => e.DOCNUMBR)
                    .HasColumnName("DOCNUMBR")
                    .HasMaxLength(21)
                    .IsRequired();

                entity.Property(e => e.INVCNMBR)
                    .HasColumnName("INVCNMBR")
                    .HasMaxLength(21)
                    .IsRequired();

                entity.Property(e => e.TAXDTLID)
                    .HasColumnName("TAXDTLID")
                    .HasMaxLength(15)
                    .IsRequired();

                entity.Property(e => e.TAXAMNT)
                    .HasColumnName("TAXAMNT")
                    .HasColumnType("numeric(19, 5)")
                    .IsRequired();

                entity.Property(e => e.STAXAMNT)
                    .HasColumnName("STAXAMNT")
                    .HasColumnType("numeric(19, 5)")
                    .IsRequired();

                entity.Property(e => e.TAXDTSLS)
                    .HasColumnName("TAXDTSLS")
                    .HasColumnType("numeric(19, 5)")
                    .IsRequired();

                entity.Property(e => e.ProductGroup)
                    .HasColumnName("ProductGroup")
                    .HasMaxLength(31);

                entity.Property(e => e.ACTNUMST)
                    .HasColumnName("ACTNUMST")
                    .HasMaxLength(129);

                entity.Property(e => e.DEX_ROW_ID)
                    .HasColumnName("DEX_ROW_ID")
                    .ValueGeneratedOnAdd()
                    .IsRequired();
            });


            modelBuilder.Entity<NXFCE101>(entity =>
            {
                entity.ToTable("NXFCE101");

                entity.HasKey(e => e.IdBookingLine);

                entity.Property(e => e.IdBookingLine)
                    .HasColumnName("IdBookingLine")
                    .HasMaxLength(31)
                    .IsRequired();

                entity.Property(e => e.INTERID)
                    .HasColumnName("INTERID")
                    .HasMaxLength(5)
                    .IsRequired();

                entity.Property(e => e.RMDTYPAL)
                    .HasColumnName("RMDTYPAL")
                    .IsRequired();

                entity.Property(e => e.DOCNUMBR)
                    .HasColumnName("DOCNUMBR")
                    .HasMaxLength(21)
                    .IsRequired();

                entity.Property(e => e.INVCNMBR)
                    .HasColumnName("INVCNMBR")
                    .HasMaxLength(21)
                    .IsRequired();

                entity.Property(e => e.BookingCode)
                    .HasColumnName("BookingCode")
                    .HasMaxLength(31);

                entity.Property(e => e.CMPNYNUM)
                    .HasColumnName("CMPNYNUM")
                    .HasMaxLength(15);

                entity.Property(e => e.ProductGroup)
                    .HasColumnName("ProductGroup")
                    .HasMaxLength(31);

                entity.Property(e => e.PaxNumber)
                    .HasColumnName("PaxNumber")
                    .HasMaxLength(11);

                entity.Property(e => e.DOCAMNT)
                    .HasColumnName("DOCAMNT")
                    .HasColumnType("numeric(19, 5)")
                    .IsRequired();

                entity.Property(e => e.COMMAMNT)
                    .HasColumnName("COMMAMNT")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.ExSLCode)
                    .HasColumnName("ExSLCode")
                    .HasMaxLength(31);

                entity.Property(e => e.AnalyticCode)
                    .HasColumnName("AnalyticCode")
                    .HasMaxLength(31);

                entity.Property(e => e.Client)
                    .HasColumnName("Client")
                    .HasMaxLength(31);

                entity.Property(e => e.CURNCYID)
                    .HasColumnName("CURNCYID")
                    .HasMaxLength(15);

                entity.Property(e => e.ExtPurchCode)
                    .HasColumnName("ExtPurchCode")
                    .HasMaxLength(31);

                entity.Property(e => e.ExSaCoMCod)
                    .HasColumnName("ExSaCoMCod")
                    .HasMaxLength(31);

                entity.Property(e => e.TOTALPAY)
                    .HasColumnName("TOTALPAY")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.AMNTPAID)
                    .HasColumnName("AMNTPAID")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.Amount_Received)
                    .HasColumnName("Amount_Received")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.REFRENCE)
                    .HasColumnName("REFRENCE")
                    .HasMaxLength(31);

                entity.Property(e => e.TRDISAMT)
                    .HasColumnName("TRDISAMT")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.DEX_ROW_ID)
                    .HasColumnName("DEX_ROW_ID")
                    .ValueGeneratedOnAdd()
                    .IsRequired();
            });

            modelBuilder.Entity<NXFCE100>(entity =>
            {
                entity.ToTable("NXFCE100");

                entity.HasKey(e => e.INTERID);

                entity.Property(e => e.INTERID)
                    .HasColumnName("INTERID")
                    .HasMaxLength(5)
                    .IsRequired();

                entity.Property(e => e.RMDTYPAL)
                    .HasColumnName("RMDTYPAL")
                    .IsRequired();

                entity.Property(e => e.DOCNUMBR)
                    .HasColumnName("DOCNUMBR")
                    .HasMaxLength(21)
                    .IsRequired();

                entity.Property(e => e.INVCNMBR)
                    .HasColumnName("INVCNMBR")
                    .HasMaxLength(21)
                    .IsRequired();

                entity.Property(e => e.BACHNUMB)
                    .HasColumnName("BACHNUMB")
                    .HasMaxLength(15);

                entity.Property(e => e.CustVenID)
                    .HasColumnName("CustVenID")
                    .HasMaxLength(15);

                entity.Property(e => e.CUSTNMBR)
                    .HasColumnName("CUSTNMBR")
                    .HasMaxLength(15);

                entity.Property(e => e.CUSTNAME)
                    .HasColumnName("CUSTNAME")
                    .HasMaxLength(65);

                entity.Property(e => e.SHIPMTHD)
                    .HasColumnName("SHIPMTHD")
                    .HasMaxLength(15);

                entity.Property(e => e.TAXSCHID)
                    .HasColumnName("TAXSCHID")
                    .HasMaxLength(15);

                entity.Property(e => e.SHRTNAME)
                    .HasColumnName("SHRTNAME")
                    .HasMaxLength(15);

                entity.Property(e => e.AccountSales)
                    .HasColumnName("AccountSales")
                    .HasMaxLength(129);

                entity.Property(e => e.AccountRecive)
                    .HasColumnName("AccountRecive")
                    .HasMaxLength(129);

                entity.Property(e => e.AccountCost)
                    .HasColumnName("AccountCost")
                    .HasMaxLength(129);

                entity.Property(e => e.AccountProv)
                    .HasColumnName("AccountProv")
                    .HasMaxLength(129);

                entity.Property(e => e.AccountTrade)
                    .HasColumnName("AccountTrade")
                    .HasMaxLength(129);

                entity.Property(e => e.NGOAccountCred)
                    .HasColumnName("NGOAccountCred")
                    .HasMaxLength(129);

                entity.Property(e => e.NGOAccountDeb)
                    .HasColumnName("NGOAccountDeb")
                    .HasMaxLength(129);

                entity.Property(e => e.AccountIngFisticio)
                    .HasColumnName("AccountIngFisticio")
                    .HasMaxLength(129);

                entity.Property(e => e.AccountCosFisticio)
                    .HasColumnName("AccountCosFisticio")
                    .HasMaxLength(129);

                entity.Property(e => e.AccountElimicion)
                    .HasColumnName("AccountElimicion")
                    .HasMaxLength(129);

                entity.Property(e => e.DOCDESCR)
                    .HasColumnName("DOCDESCR")
                    .HasMaxLength(31);

                entity.Property(e => e.AADIMCHANEL)
                    .HasColumnName("AADIMCHANEL")
                    .HasMaxLength(31);

                entity.Property(e => e.AAPROJECT)
                    .HasColumnName("AAPROJECT")
                    .HasMaxLength(31);

                entity.Property(e => e.VALUEPROJECT)
                    .HasColumnName("VALUEPROJECT")
                    .HasMaxLength(31);

                entity.Property(e => e.DOCDATE)
                    .HasColumnName("DOCDATE")
                    .IsRequired();

                entity.Property(e => e.Total_Sales)
                    .HasColumnName("Total_Sales")
                    .HasColumnType("numeric(19, 5)")
                    .IsRequired();

                entity.Property(e => e.CURNCYID)
                    .HasColumnName("CURNCYID")
                    .HasMaxLength(15);

                entity.Property(e => e.RATETPID)
                    .HasColumnName("RATETPID")
                    .HasMaxLength(15);

                entity.Property(e => e.APPLDAMT)
                    .HasColumnName("APPLDAMT")
                    .HasColumnType("numeric(19, 5)");

                entity.Property(e => e.APFRDCDT)
                    .HasColumnName("APFRDCDT");

                entity.Property(e => e.APFRDCNM)
                    .HasColumnName("APFRDCNM")
                    .HasMaxLength(21);

                entity.Property(e => e.DATERECD)
                    .HasColumnName("DATERECD");

                entity.Property(e => e.DATEDONE)
                    .HasColumnName("DATEDONE");

                entity.Property(e => e.ERROR)
                    .HasColumnName("ERROR");

                entity.Property(e => e.NUMOCPIS)
                    .HasColumnName("NUMOCPIS");

                entity.Property(e => e.DEX_ROW_ID)
                    .HasColumnName("DEX_ROW_ID")
                    .ValueGeneratedOnAdd()
                    .IsRequired();
            });

            modelBuilder.Ignore<IdentityUserLogin<string>>();
        }
    }
}
