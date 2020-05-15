using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ModelStd.DB.Stock
{
    [Table("StockExchange", Schema = "stock")]
    public class StockExchange
    {

        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("exchangeDate")]
        [Required]
        public DateTime ExchangeDate { get; set; }

        [Column("soldSymbolId")]
        [Required]
        public int SoldSymbolId { get; set; }

        [Column("soldSymbolVolume")]
        [Required]
        public int SoldSymbolVolume { get; set; }

        [Column("soldSymbolPricePerShare")]
        [Required]
        public double SoldSymbolPricePerShare { get; set; }


        [Column("boughtSymbolId")]
        [Required]
        public int BoughtSymbolId { get; set; }

        [Column("boughtSymbolVolume")]
        [Required]
        public int BoughtSymbolVolume { get; set; }

        [Column("boughtSymbolPricePerShare")]
        [Required]
        public double BoughtSymbolPricePerShare { get; set; }

        public virtual Symbol SoldSymbol { get; set; }
        public virtual Symbol BoughtSymbol { get; set; }
    }
}
