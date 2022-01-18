using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ModelStd.DB.Product

{

    [Table("Product", Schema = "stock")]
    public class Product
    {
        [Key]
        [Column("id")]
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

        
        [Column("groupId")]
        [Required]
        public int GroupId { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }

    }
}
