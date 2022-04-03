namespace Warehouse_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Demand
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Cust_Email { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Warehouse_Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Item_Code { get; set; }

        [StringLength(50)]
        public string Demand_Code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Quantity { get; set; }

        public DateTime? Created_At { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Item Item { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
