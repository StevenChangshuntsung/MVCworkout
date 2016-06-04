namespace NewRepo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [StringLength(20)]
        public string AC_Empid { get; set; }

        [StringLength(2)]
        public string AC_Level { get; set; }

        [StringLength(2)]
        public string AC_Enable { get; set; }

        [StringLength(20)]
        public string AC_Emppasswd { get; set; }

        [StringLength(20)]
        public string AC_Empname { get; set; }

        [StringLength(20)]
        public string AC_Group { get; set; }

        public int AC_DptID { get; set; }

        [StringLength(10)]
        public string AC_Msid { get; set; }

        [StringLength(100)]
        public string AC_Email { get; set; }

        [StringLength(100)]
        public string AC_Tel { get; set; }

        [StringLength(100)]
        public string AC_MOB { get; set; }

        [StringLength(2)]
        public string AC_ifemail { get; set; }

        [StringLength(20)]
        public string AC_Baddid { get; set; }

        public DateTime? AC_Badddate { get; set; }

        [StringLength(20)]
        public string AC_Bmodid { get; set; }

        public DateTime? AC_Bmoddate { get; set; }

        [StringLength(20)]
        public string AC_Mweb { get; set; }

        [StringLength(2)]
        public string AC_Language { get; set; }

        [StringLength(2)]
        public string AC_Ifboss { get; set; }
    }
}
