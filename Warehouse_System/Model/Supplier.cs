namespace Warehouse_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            Supplies = new HashSet<Supply>();
        }

        [Key]
        [StringLength(50)]
        public string Sup_Email { get; set; }

        [StringLength(50)]
        public string Sup_Name { get; set; }

        [StringLength(50)]
        public string Sup_Phonenumber { get; set; }

        [StringLength(50)]
        public string Sup_Mobile { get; set; }

        [StringLength(50)]
        public string Sup_Fax { get; set; }

        [StringLength(50)]
        public string Sup_Website { get; set; }

        public DateTime? Created_At { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply> Supplies { get; set; }
    }
}
