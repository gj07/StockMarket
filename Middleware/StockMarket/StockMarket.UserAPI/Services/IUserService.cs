﻿using StockMarket.UserAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.UserAPI.Services
{
    public interface IUserService
    {
        //public List<Company> Search(string exp);
        public Company Search(string compname);
    }
}
