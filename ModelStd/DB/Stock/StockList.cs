using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelStd.DB.Stock
{
    [Table("StockList", Schema = "stock")]
    public class StockList
    {
        public StockList()
        {
            StockListStockInfo = new HashSet<StockListStockInfo>();
        }

        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public virtual ICollection<StockListStockInfo> StockListStockInfo { get; set; }
    }

    [Table("StockListStockInfo", Schema = "stock")]
    public class StockListStockInfo
    {
        
        [Column("listId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ListId { get; set; }

        public StockList StockList { get; set; }

        [Column("stockInfoId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockInfoId { get; set; }

        public StockInfo StockInfo { get; set; }

    }
}
