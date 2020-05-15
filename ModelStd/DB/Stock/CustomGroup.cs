using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelStd.DB.Stock
{
    [Table("CustomGroup", Schema = "stock")]
    public class CustomGroup
    {
        public CustomGroup()
        {
            CustomGroupMembers = new HashSet<CustomGroupMember>();
        }

        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        public virtual ICollection<CustomGroupMember> CustomGroupMembers { get; set; }
    }

    [Table("customGroupMember", Schema = "stock")]
    public class CustomGroupMember
    {
        
        [Column("groupId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupId { get; set; }

        public CustomGroup StockList { get; set; }

        [Column("symbolId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SymbolId { get; set; }

        public Symbol Symbol { get; set; }

    }
}
