namespace Warehouse_System.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Items_Measureunits
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Item_code { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Mesureunit_Name { get; set; }

        public DateTime? Created_At { get; set; }

        public virtual Item Item { get; set; }
    }
}
