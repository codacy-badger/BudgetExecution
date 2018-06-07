namespace BudgetExecution.src
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MD")]
    public partial class MD
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string BudgetLevel { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string RPIO { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string BFY { get; set; }

        [Required]
        [StringLength(50)]
        public string Fund { get; set; }

        [Required]
        [StringLength(50)]
        public string FundName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string BOC { get; set; }

        [Required]
        [StringLength(50)]
        public string BocName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Org { get; set; }

        [Required]
        [StringLength(50)]
        public string RC { get; set; }

        [Required]
        [StringLength(50)]
        public string DivisionName { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public double Amount { get; set; }

        [StringLength(50)]
        public string SubProject { get; set; }

        [Required]
        [StringLength(50)]
        public string NPM { get; set; }

        [Required]
        [StringLength(50)]
        public string NpmCode { get; set; }

        [Required]
        [StringLength(50)]
        public string ProgramProjectCode { get; set; }

        [Required]
        [StringLength(50)]
        public string ProgramProjectName { get; set; }

        [Required]
        [StringLength(50)]
        public string ProgramArea { get; set; }

        [Required]
        [StringLength(50)]
        public string ProgramAreaName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Goal { get; set; }

        [Required]
        [StringLength(50)]
        public string GoalName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Objective { get; set; }

        [Required]
        [StringLength(50)]
        public string ObjectiveName { get; set; }
    }
}
