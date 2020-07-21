namespace ConsoleApp18
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class create_pps
    {
        public int id { get; set; }

        [StringLength(50)]
        public string postinbank { get; set; }

        [StringLength(50)]
        public string spissoschet { get; set; }

        [StringLength(50)]
        public string form_okyd { get; set; }

        [StringLength(50)]
        public string name_bank_docum { get; set; }

        [StringLength(50)]
        public string number_pp { get; set; }

        [StringLength(50)]
        public string date_pp { get; set; }

        [StringLength(50)]
        public string vid_platezha { get; set; }

        [StringLength(50)]
        public string status_platelshik { get; set; }

        [StringLength(50)]
        public string summa_propisiu { get; set; }

        [StringLength(50)]
        public string INN_platelshika { get; set; }

        [StringLength(50)]
        public string KPP_platelshika { get; set; }

        [StringLength(50)]
        public string Summa_platelshika { get; set; }

        [StringLength(100)]
        public string Name_platelshika { get; set; }

        [StringLength(50)]
        public string Acc_platelshika { get; set; }

        [StringLength(100)]
        public string bank_platelshika { get; set; }

        [StringLength(50)]
        public string BIK_platelshika { get; set; }

        [StringLength(50)]
        public string KOR_poluchat { get; set; }

        [StringLength(100)]
        public string BANK_poluchat { get; set; }

        [StringLength(50)]
        public string BIK_poluchat { get; set; }

        [StringLength(50)]
        public string ACC_bank_poluchat { get; set; }

        [StringLength(50)]
        public string INN_poluchat { get; set; }

        [StringLength(50)]
        public string KPP_poluchat { get; set; }

        [StringLength(50)]
        public string ACC_poluchat { get; set; }

        [StringLength(100)]
        public string name_poluchat { get; set; }

        [StringLength(50)]
        public string shifr_pp { get; set; }

        [StringLength(50)]
        public string srochnost { get; set; }

        [StringLength(50)]
        public string naznachenie { get; set; }

        [StringLength(50)]
        public string ocherednost { get; set; }

        [StringLength(50)]
        public string kod { get; set; }

        [StringLength(50)]
        public string rezerv { get; set; }

        [StringLength(50)]
        public string KBK { get; set; }

        [StringLength(50)]
        public string OKTMO { get; set; }

        [StringLength(50)]
        public string osnovanie_pp { get; set; }

        [StringLength(50)]
        public string nalog_period { get; set; }

        [StringLength(50)]
        public string Nomer_docum { get; set; }

        [StringLength(50)]
        public string date_docum { get; set; }

        [StringLength(50)]
        public string kod_vyplatu { get; set; }

        [StringLength(50)]
        public string naznachenie_PP { get; set; }

        [StringLength(50)]
        public string MP { get; set; }

        [StringLength(50)]
        public string PODPIS { get; set; }

        [StringLength(50)]
        public string BANK_OTMETK { get; set; }

        [StringLength(50)]
        public string status { get; set; }
    }
}
