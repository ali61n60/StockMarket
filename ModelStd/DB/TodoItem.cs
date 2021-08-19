using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelStd.DB
{
    [Table("ToDo", Schema = "stock")]
    public class TodoItem
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        
        [Column("name")]
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Column("isComplete",TypeName ="bit")]
        [Required]        
        public bool IsComplete { get; set; }
    }
}
