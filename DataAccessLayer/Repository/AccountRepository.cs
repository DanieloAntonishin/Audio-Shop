using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using DataAccessLayer.EF;

namespace DataAccessLayer.Repository
{
    public class AccountRepository
    {
        private Context DB;
        public AccountRepository(Context context)
        {
            DB = context;
        }
        public IEnumerable<Account> ReadAll()
        {
            return DB.Accounts;
        }
        public Account Read(int id)
        {
            return DB.Accounts.Find(id);
        }
        public void Create(Account account)
        {
            DB.Accounts.Add(account);
        }
    }
}
