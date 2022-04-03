namespace Warehouse_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supply
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Sup_Email { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Warehouse_Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Item_code { get; set; }

        [StringLength(50)]
        public string Supply_Code { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Quantity { get; set; }

        public int? Expire_Days { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Production_Date { get; set; }

        public DateTime? Created_At { get; set; }

        public virtual Item Item { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
