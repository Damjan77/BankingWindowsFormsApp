namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ExchangeRate
    {
        [Key]
        public int? exchangeRatesId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ValidityDate { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyFrom { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyTo { get; set; }

        public decimal Rate { get; set; }

        public bool IsActive { get; set; }
    }
}
