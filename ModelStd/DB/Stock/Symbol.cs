using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelStd.DB.Stock
{
    [Table("Symbol", Schema = "stock")]
    public class Symbol
    {
        public Symbol()
        {
            StockListStockInfo = new HashSet<StockListStockInfo>();
        }

        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
                     
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

        public virtual SymbolGroup SymbolGroup { get; set; }
        public virtual LiveDataUrl LiveDataUrl { get; set; }

        public virtual ICollection<Dividend> Dividends { get; set; }
        public virtual ICollection<StockTrading> StockTradings { get; set; }
        public virtual ICollection<StockListStockInfo> StockListStockInfo { get; set; }
    }
}      
