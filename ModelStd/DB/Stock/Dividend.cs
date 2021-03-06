﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelStd.DB.Stock
{
    [Table("Dividend", Schema = "stock")]
    public class Dividend
    {        
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("symbolId")]        
        public int SymbolId { get; set; }

        [Column("date")]
        [Required]
        public DateTime Date { get; set; }

        [Column("value")]
        [Required]
        public double Value { get; set; }

        public virtual Symbol Symbol { get; set; }

    }
}
