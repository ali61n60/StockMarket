using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelStd.DB.Stock;

namespace ModelStd.DB
{
    [Table("Trades", Schema = "stock")]
    public class StockTrading
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("shareholderId")]
        [Required]
        public int ShareholderId { get; set; }

        [Column("symbolId")]
        [Required]
        public int SymbolId { get; set; }

        [Column("tradeType")]
        [Required]
        public TradeType TradeType { get; set; }

        [Column("volume")]
        [Required]
        public int Volume { get; set; }

        [Column("pricePerShare")]
        [Required]
        public double PricePerShare { get; set; }

        [Column("totalPrice")]
        [Required]
        public double TotalPrice { get; set; }

        [Column("date")]
        [Required]
        public DateTime Date { get; set; }


        public virtual Shareholder Shareholder { get; set; }
        public virtual Symbol Symbol { get; set; }
    }

    public enum TradeType
    {
        Buy,
        Sell
    }
}
