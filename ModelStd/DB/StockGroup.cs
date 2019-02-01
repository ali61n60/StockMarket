﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelStd.DB
{
    [Table("StockGroup", Schema = "stock")]
    public class StockGroup
    {
        [Column("groupId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupId { get; set; }

        [Column("groupName")]
        [Required]
        [MaxLength(150)]
        public string groupName { get; set; }

        public virtual ICollection<StockInfo> Stocks { get; set; }

    }
}
