using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        [StringLength(30)]
        public string CompanyCode { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }

        [StringLength(30)]
        public string CEO { get; set; }

        public string BoardOfDirectors { get; set; }

        [StringLength(10)]
        public string StockExchangesListedOn { get; set; }

        public IEnumerable<StockPrice> StockPrices { get; set; }

        public IEnumerable<IPO> IPOs { get; set; }
    }
}
