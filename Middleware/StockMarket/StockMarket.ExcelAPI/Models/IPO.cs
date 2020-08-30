using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.ExcelAPI.Models
{
    [Table("IPO")]
    public class IPO
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
        public double PricePerShare { get; set; }

        [Required]
        public int NumberOfShares { get; set; }

        [Required]
        public DateTime dateTime { get; set; }

        public string Remarks { get; set; }

        public Company Company { get; set; }
    }
}
