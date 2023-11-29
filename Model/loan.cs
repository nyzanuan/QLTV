namespace QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class loan
    {
        public int id { get; set; }

        public int? user_id { get; set; }

        public int? book_id { get; set; }

        public DateTime? loan_date { get; set; }

        public DateTime? return_date { get; set; }

        public virtual book book { get; set; }

        public virtual user user { get; set; }
    }
}
