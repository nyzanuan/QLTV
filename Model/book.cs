namespace QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class book
    {
        public int id { get; set; }

        [StringLength(50)]
        public string title { get; set; }

        public int? author_id { get; set; }

        [StringLength(500)]
        public string description { get; set; }

        public int? pages { get; set; }

        public int? language_id { get; set; }

        public int? quantity { get; set; }

        public int? categories_id { get; set; }

        public virtual author author { get; set; }

        public virtual language language { get; set; }

        public virtual loan loan { get; set; }
    }
}
