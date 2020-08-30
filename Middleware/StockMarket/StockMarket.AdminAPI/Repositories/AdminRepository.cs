using StockMarket.AdminAPI.DBAccess;
using StockMarket.AdminAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AdminAPI.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private StockDBContext _context;

        public AdminRepository(StockDBContext context)
        {
            _context = context;
        }
        public void addCompany(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public void editCompany(Company company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
        }

        public List<Company> getAllCompanies()
        {
            return _context.Companies.ToList();
        }

        public Company getCompany(string company_code)
        {
            return _context.Companies.Find(company_code);
        }

        public void removeCompany(string company_code)
        {
            _context.Companies.Remove(_context.Companies.Find(company_code));
            _context.SaveChanges();
        }
    }
}
