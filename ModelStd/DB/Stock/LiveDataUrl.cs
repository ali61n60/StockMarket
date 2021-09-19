using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ModelStd.DB.Stock
{

    [Table("LiveDataUrl", Schema = "stock")]
    public class LiveDataUrl
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("url")]
        [Required]
        [MaxLength(500)]
        public string Url { get; set; }


        [Column("symbolId")]
        [Required]
        public int SymbolId { get; set; }

      //  public virtual Symbol Symbol { get; set; }



    }
}
