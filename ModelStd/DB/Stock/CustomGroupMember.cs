using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelStd.DB.Stock
{
    [Table("customGroupMember", Schema = "stock")]
    public class CustomGroupMember
    {

        [Column("groupId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupId { get; set; }

        public CustomGroup Group { get; set; }

        [Column("symbolId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SymbolId { get; set; }

        public Symbol Symbol { get; set; }

    }
}
