using System;
using DataAccessLayer;
using DataAccessLayer.Entities;
using System.Collections.Generic;
using BusinessLogic.Entities;
using AutoMapper;

namespace BusinessLogic
{
   public class BL:IDisposable
    {
        private UniteOfTable DB { get; }
        public BL()
        {
            DB = new UniteOfTable();
        }
        public void AddAccount(AccountBL element)
        {
            DB.Account.Create(Mapper.Map<Account>(element));
            DB.Save();
        }
        public IEnumerable<AccountBL> GetAccounts()
        {
            List<AccountBL> result = new List<AccountBL>();

            foreach (var item in DB.Account.ReadAll())
                result.Add(Mapper.Map<AccountBL>(item));

            return result;
        }

        public void AddProduct(ProductBL element)
        {
            DB.Product.Create(Mapper.Map<Product>(element));
            DB.Save();
        }
        public IEnumerable<ProductBL> GetProducts()
        {
            List<ProductBL> result = new List<ProductBL>();

            foreach (var item in DB.Product.ReadAll())
                result.Add(Mapper.Map<ProductBL>(item));

            return result;
        }
        public void DeleteProduct(ProductBL element)
        {
            DB.Product.Delete(element.Id);
            DB.Save();
        }
        public void Dispose()
        {
            DB.Dispose();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
