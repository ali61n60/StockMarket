using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelStd.DB.Stock
{
    [Table("CapitalIncrease", Schema = "stock")]
    public class CapitalIncrease
    {

        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("stockId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockId { get; set; }

        [Column("date")]
        [Required]
        public DateTime Date { get; set; }

        [Column("percent")]
        [Required]
        public double Percent { get; set; }

        [Column("cashPercent")]
        [Required]
        public double CashPercent { get; set; }

        [Column("savingPercent")]
        [Required]
        public double SavingPercent { get; set; }

        public virtual Symbol StockInfo { get; set; }

    }
}
