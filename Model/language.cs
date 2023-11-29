namespace QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class language
    {
        public int id { get; set; }

        [Column("language")]
        [StringLength(50)]
        public string language1 { get; set; }

        public virtual book book { get; set; }
    }
}
