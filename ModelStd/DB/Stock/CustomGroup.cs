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

   
}
