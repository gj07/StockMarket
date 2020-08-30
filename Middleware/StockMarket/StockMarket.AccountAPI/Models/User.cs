using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [MaxLength(30)]
        public string UserId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Username { get; set; }

        [Required]
        [MaxLength(30)]
        public string Password { get; set; }

        [MaxLength(30)]
        public string Email { get; set; }

        [MaxLength(30)]
        public string Mobile { get; set; }

        [MaxLength(30)]
        public string Confirmed { get; set; }

    }
}
