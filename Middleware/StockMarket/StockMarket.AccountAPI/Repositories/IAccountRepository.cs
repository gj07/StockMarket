using StockMarket.AccountAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Repositories
{
    public interface IAccountRepository
    {
        public void addUser(User user);
        public User validate(string username, string password);
        public void updateUser(User user);
        public User getUser(string id);

    }
}
