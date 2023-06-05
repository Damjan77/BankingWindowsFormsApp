namespace WindowsFormsApp1
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class OfficialRate
    {
        [Key]
        public int? OfficialRatesId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ValidityDate { get; set; }

        [Required]
        [StringLength(3)]
        public string Currency { get; set; }

        public decimal Rate { get; set; }

        public bool isActive { get; set; }
    }
}
