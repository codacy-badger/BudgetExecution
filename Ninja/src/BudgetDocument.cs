namespace BudgetExecution.src
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BudgetDocument")]
    public partial class BudgetDocument
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string FiscalYear { get; set; }

        [Required]
        [StringLength(50)]
        public string Region { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string RegionControlNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Fund { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string FundControlNumber { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        [Required]
        [StringLength(50)]
        public string DivisionID { get; set; }

        public int BudgetControlNumber { get; set; }
    }
}
