using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelStd.DB.Stock
{
    [Table("StocksInfo", Schema = "stock")]
    public class StockInfo
    {
        public StockInfo()
        {
            StockListStockInfo = new HashSet<StockListStockInfo>();
        }

        [Key]
        [Column("stockId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockId { get; set; }
                     
        [Column("symbolLatin")]
        [Required]
        [MaxLength(150)]
        public string SymbolLatin { get; set; }

        [Column("nameLatin")]
        [Required]
        [MaxLength(150)]
        public string NameLatin { get; set; }

        [Column("namePersian")]
        [Required]
        [MaxLength(150)]
        public string NamePersian { get; set; }

        [Column("symbolPersian")]
        [Required]
        [MaxLength(150)]
        public string SymbolPersian { get; set; }

        [Column("groupId")]        
        [Required]
        public int GroupId { get; set; }

        public virtual SymbolGroup StockGroup { get; set; }

        public virtual ICollection<Dividend> Dividends { get; set; }
        public virtual ICollection<StockTrading> StockTradings { get; set; }
        public virtual ICollection<StockListStockInfo> StockListStockInfo { get; set; }
    }
}      
