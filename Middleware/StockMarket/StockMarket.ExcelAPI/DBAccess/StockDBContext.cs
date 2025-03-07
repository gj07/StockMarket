﻿using Microsoft.EntityFrameworkCore;
using StockMarket.ExcelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.ExcelAPI.DBAccess
{
    public class StockDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<StockPrice> StockPrices { get; set; }
        public DbSet<IPO> IPOs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-O4N6UKJ\\SQLEXPRESS;Initial Catalog=StockMarketDB;Integrated Security=True");
        }
    }
}
