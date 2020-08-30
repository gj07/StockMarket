using StockMarket.AccountAPI.Models;
using StockMarket.AccountAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepository _repository;

        public AccountService(IAccountRepository repository)
        {
            _repository = repository;
        }
        public void addUser(User user)
        {
            _repository.addUser(user);
        }

        public User getUser(string id)
        {
            throw new NotImplementedException();
        }

        public void updateUser(User user)
        {
            _repository.updateUser(user);
        }

        public User validate(string username, string password)
        {
            return _repository.validate(username, password);
        }
    }
}
