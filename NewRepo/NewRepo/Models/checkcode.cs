namespace NewRepo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("checkcode")]
    public partial class checkcode
    {
        [Key]
        public int cid { get; set; }

        [StringLength(2)]
        public string chkclass { get; set; }

        [StringLength(50)]
        public string chkclasstitle { get; set; }

        [StringLength(2)]
        public string chkcode { get; set; }

        [StringLength(100)]
        public string chkitem { get; set; }

        [StringLength(10)]
        public string bmodid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? bmoddate { get; set; }
    }
}
