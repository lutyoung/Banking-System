using BankingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Interface.IService
{
    public interface IManagerService
    {
        public Manager AddManager(Manager manager);

        public Manager GetManager(int id);

        public void DeleteManager(int id);

        public List<Manager> GetAll();

        public Manager UpdateManager(Manager manager);
    }
}
