using StockMarket.UserAPI.Models;
using StockMarket.UserAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.UserAPI.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        /*
         public List<Company> Search(string exp){
            return _userRepo.Search(exp);
         }
         */
        public Company Search(string compname)
        {
            return _userRepo.Search(compname);
        }
    }
}
