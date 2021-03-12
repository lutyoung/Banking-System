using BankingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Interface.IRepository
{
    public interface IManagerRepository
    {
        public Manager AddManager(Manager manager);

        //public Manager FindByEmail(string email);

        //public Manager FindById(int id);

        public Manager UpdateManager(Manager manager);

        public Manager GetManager(int id);

        public List<Manager> GetAll();
         
        public void DeleteManager(int id);
    }
}
