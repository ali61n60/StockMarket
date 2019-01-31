using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelStd.DB
{
    [Table("CapitalIncrease", Schema = "stock")]
    class CapitalIncrease
    {
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

    }
}
