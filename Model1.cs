namespace ConsoleApp18
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<create_pps> create_pps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<create_pps>()
                .Property(e => e.postinbank)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.spissoschet)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.form_okyd)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.name_bank_docum)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.number_pp)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.date_pp)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.vid_platezha)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.status_platelshik)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.summa_propisiu)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.INN_platelshika)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.KPP_platelshika)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.Summa_platelshika)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.Name_platelshika)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.Acc_platelshika)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.bank_platelshika)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.BIK_platelshika)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.KOR_poluchat)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.BANK_poluchat)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.BIK_poluchat)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.ACC_bank_poluchat)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.INN_poluchat)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.KPP_poluchat)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.ACC_poluchat)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.name_poluchat)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.shifr_pp)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.srochnost)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.naznachenie)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.ocherednost)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.kod)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.rezerv)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.KBK)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.OKTMO)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.osnovanie_pp)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.nalog_period)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.Nomer_docum)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.date_docum)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.kod_vyplatu)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.naznachenie_PP)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.MP)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.PODPIS)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.BANK_OTMETK)
                .IsUnicode(false);

            modelBuilder.Entity<create_pps>()
                .Property(e => e.status)
                .IsUnicode(false);
        }
    }
}
