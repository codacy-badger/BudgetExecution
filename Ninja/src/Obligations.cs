namespace BudgetExecution.src
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Obligations
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RPIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Fund { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string NpmCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BFY { get; set; }

        [StringLength(50)]
        public string System { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string RC { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Division { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string RpioActivityActivity { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string ProgramProjectCode { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BOC { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FOC { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string FocName { get; set; }

        [StringLength(50)]
        public string PurchaseRequest { get; set; }

        [StringLength(50)]
        public string DcnPrefix { get; set; }

        [StringLength(50)]
        public string DocType { get; set; }

        [StringLength(50)]
        public string DCN { get; set; }

        [StringLength(50)]
        public string Site_Project { get; set; }

        [StringLength(100)]
        public string SiteProjectName { get; set; }

        [StringLength(50)]
        public string GrantNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CommitmentDateDisplay { get; set; }

        [Key]
        [Column(Order = 11)]
        public double Commitments { get; set; }

        [Key]
        [Column("Obligations", Order = 12)]
        public double Obligations1 { get; set; }
    }
}
