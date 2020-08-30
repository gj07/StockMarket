using StockMarket.AdminAPI.Models;
using StockMarket.AdminAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AdminAPI.Services
{
    public class AdminService : IAdminService
    {
        private IAdminRepository _adminRepo;

        public AdminService(IAdminRepository adminRepo)
        {
            _adminRepo = adminRepo;
        }

        public void addCompany(Company company)
        {
            _adminRepo.addCompany(company);
        }

        public void editCompany(Company company)
        {
            _adminRepo.editCompany(company);
        }

        public List<Company> getAllCompanies()
        {
            return _adminRepo.getAllCompanies();
        }

        public Company getCompany(string company_code)
        {
            return _adminRepo.getCompany(company_code);
        }

        public void removeCompany(string company_code)
        {
            _adminRepo.removeCompany(company_code);
        }
    }
}
