using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ModelStd.DB.Product
{
    [Table("ProductGroup", Schema = "stock")]
    public class ProductGroup
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("nameLatin")]
        [Required]
        [MaxLength(150)]
        public string NameLatin { get; set; }

        [Column("namePersian")]
        [Required]
        [MaxLength(150)]
        public string NamePersian { get; set; }


        public virtual ICollection<Product> Products { get; set; }

    }
}
