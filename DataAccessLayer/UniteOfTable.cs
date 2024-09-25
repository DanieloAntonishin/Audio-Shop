using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using DataAccessLayer.Repository;
using DataAccessLayer.EF;

namespace DataAccessLayer
{
    public class UniteOfTable
    {
        private Context DataBase { get; }
        private AccountRepository account;
        private ProductRepository product;
        public UniteOfTable()
        {
            DataBase = new Context();
        }
        public AccountRepository Account
        {
            get
            {
                if (account == null)
                    account = new AccountRepository(DataBase);
                return account;
            }
        }
        public ProductRepository Product
        {
            get
            {
                product = new ProductRepository(DataBase);
                return product;
            }
        }
        public void Save()
        {
            DataBase.SaveChanges();
        }
        public void Dispose()
        {
            DataBase.Dispose();
        }
    }
}
