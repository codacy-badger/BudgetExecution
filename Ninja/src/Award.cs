namespace BudgetExecution.src
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Award")]
    public partial class Award
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string RC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string DivisionName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Fund { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string FundName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string BFY { get; set; }

        [Key]
        [Column(Order = 6)]
        [MaxLength(50)]
        public byte[] BOC { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string BocName { get; set; }

        public double? Amount { get; set; }

        [StringLength(1)]
        public string Time { get; set; }
    }
}
