using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelStd.DB.Stock
{
    [Table("TradeData", Schema = "stock")]
    public class TradeData
    {

        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("stockId")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockId { get; set; }

        [Column("date")]
        [Required]
        public DateTime Date { get; set; }

        [Column("volume")]
        [Required]
        public int Volume { get; set; }

        [Column("open")]
        [Required]
        public double Open { get; set; }

        [Column("close")]
        [Required]
        public double Close { get; set; }

        [Column("min")]
        [Required]
        public double Min { get; set; }

        [Column("max")]
        [Required]
        public double Max { get; set; }

        [Column("final")]
        [Required]
        public double Final { get; set; }

        [Column("value")]
        [Required]
        public double Value { get; set; }

        [Column("numberOfDeals")]
        [Required]
        public int NumberOfDeals { get; set; }

        public void FillFromPointData(PointData pointData)
        {            
            Close = pointData.Close;
            Date = pointData.Date;
            Final = pointData.Final;
            Max = pointData.Max;
            Min = pointData.Min;
            NumberOfDeals = pointData.NumberOfDeals;
            Open = pointData.Open;
            Value = pointData.Value;
            Volume = pointData.Volume;
        }

        public PointData GetPointDate()
        {
            PointData pointData = new PointData();
            pointData.Close = Close;
            pointData.Date = Date;
            pointData.Final = Final;
            pointData.Max = Max;
            pointData.Min = Min;
            pointData.NumberOfDeals = NumberOfDeals;
            pointData.Open = Open;
            pointData.Value = Value;
            pointData.Volume = Volume;

            return pointData;
        }

        public virtual Symbol StockInfo { get; set; }

    }
}
