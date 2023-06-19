namespace WindowsFormsApp1
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Operation
    {
        public int? OperationId { get; set; }

        public int? OperationTypeId { get; set; }

        public int userId { get; set; }

        public DateTime OperationDate { get; set; }

        public decimal Amount { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyFrom { get; set; }

        [Required]
        [StringLength(3)]
        public string CurrencyTo { get; set; }

        public decimal t_money { get; set; }

        public virtual User User { get; set; }
    }
}
