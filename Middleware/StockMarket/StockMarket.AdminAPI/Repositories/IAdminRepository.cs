using StockMarket.AdminAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AdminAPI.Repositories
{
    public interface IAdminRepository
    {
        public void addCompany(Company company);

        public void removeCompany(string company_code);

        public void editCompany(Company company);

        public Company getCompany(string company_code);

        public List<Company> getAllCompanies();
    }
}
