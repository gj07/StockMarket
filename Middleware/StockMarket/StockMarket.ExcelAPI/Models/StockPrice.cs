using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.ExcelAPI.Models
{
    [Table("StockPrice")]
    public class StockPrice
    {
        [Key]
        public int RowId { get; set; }

        [ForeignKey("Company")]
        [StringLength(30)]
        public string CompanyCode { get; set; }

        [Required]
        [StringLength(5)]
        public string StockExchange { get; set; }

        [Required]
        public double CurrentPrice { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }

        public string Time { get; set; }

        public Company Company { get; set; }

    }
}
