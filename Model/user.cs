namespace QLTV
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            loans = new HashSet<loan>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string fullname { get; set; }

        public int? roleid { get; set; }

        public int? gender { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int? is_active { get; set; }

        public int? phone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<loan> loans { get; set; }

        public virtual role role { get; set; }
    }
}
