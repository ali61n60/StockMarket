using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelStd.DB
{
    [Table("TradeData", Schema = "stock")]
    public class TradeData
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

        [Column("volume")]
        [Required]
        public int Volume { get; set; }

        [Column("open")]
        [Required]
        public double Open { get; set; }

        [Column("close")]
        [Required]
        public double Close { get; set; }

        [Column("min")]
        [Required]
        public double Min { get; set; }

        [Column("max")]
        [Required]
        public double Max { get; set;}

        [Column("final")]
        [Required]
        public double Final { get; set; }

        public virtual StockName StockName { get; set; }

    }
}
