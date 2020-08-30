using StockMarket.AccountAPI.DBAccess;
using StockMarket.AccountAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.AccountAPI.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private StockDBContext _context;

        public AccountRepository(StockDBContext context)
        {
            _context = context;
        }

        public void addUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User getUser(string id)
        {
            throw new NotImplementedException();
        }

        public void updateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public User validate(string username, string password)
        {
            User user = _context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            return user;
        }
    }
}
