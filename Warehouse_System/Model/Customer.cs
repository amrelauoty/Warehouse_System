namespace Warehouse_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Demands = new HashSet<Demand>();
        }

        [Key]
        [StringLength(50)]
        public string Cust_Email { get; set; }

        [StringLength(50)]
        public string Cust_Name { get; set; }

        [StringLength(50)]
        public string Cust_Phone { get; set; }

        [StringLength(50)]
        public string Cust_Fax { get; set; }

        [StringLength(50)]
        public string Cust_Website { get; set; }

        [StringLength(50)]
        public string Cust_Mobile { get; set; }

        public DateTime? Created_At { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Demand> Demands { get; set; }
    }
}
