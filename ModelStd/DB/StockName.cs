using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelStd.DB
{
    [Table("StocksName",Schema ="stock")]
    public class StockName
    {
        [Key]
        [Column("stockId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockId { get; set; }

        [Column("stockSymbol")]
        [Required]
        [MaxLength(150)]
        public string StockSymbol { get;set }
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
 
