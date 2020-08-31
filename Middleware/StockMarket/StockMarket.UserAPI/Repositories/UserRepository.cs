using StockMarket.UserAPI.DBAccess;
using StockMarket.UserAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.UserAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private StockDBContext _context;

        public UserRepository(StockDBContext context)
        {
            _context = context;
        }
        /*public List<Company> Search(string exp)
        {
            return _context.Companies
                            .FromSqlRaw("SELECT * FROM dbo.Companies WHERE CompanyName like {0}", $"*{exp}*")
                            .ToList();
        }*/

        public Company Search(string compname)
        {
            return _context.Companies.SingleOrDefault(c => c.CompanyName == compname);
        }
    }
}
