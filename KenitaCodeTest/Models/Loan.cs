using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KenitaCodeTest.Models
{
    public class Loan
    {
        [Key]

        public int Details { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required]

        public string LoanID { get; set; }
        [Column(TypeName = "nvarchar(10)")]

        public string BorrowerName { get; set; }
        [Column(TypeName = "nvarchar(100)")]

        public string FundingAmount { get; set; }
        [Column(TypeName = "nvarchar(100)")]

        public string RepaymentAmount { get; set; }

    }
}
