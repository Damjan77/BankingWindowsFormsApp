namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Operation
    {
        public int? OperationId { get; set; }

        public int OperationTypeId { get; set; }

        public int userId { get; set; }

        public DateTime OperationDate { get; set; }

        public decimal Amount { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyFrom { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyTo { get; set; }

        public virtual User User { get; set; }
    }
}
