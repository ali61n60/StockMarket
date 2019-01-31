using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelStd.DB
{
    [Table("StocksInfo",Schema ="stock")]
    public class StockInfo
    {
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

        public virtual ICollection<Dividend> Dividends { get; set; }
    }
}



        //public Brand()
        //{
        //    CarModels = new HashSet<CarModel>();
        //    LetMeKnowAttributeTransportaion = new HashSet<LetMeKnowAttributeTransportaion>();
        //}

        //[Column("brandName")]
        //[Required]
        //[MaxLength(150)]
        //public string BrandName { get; set; }

        //public virtual ICollection<CarModel> CarModels { get; set; }
 
