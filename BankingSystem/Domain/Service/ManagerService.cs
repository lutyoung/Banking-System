using BankingSystem.Domain.Repository;
using BankingSystem.Interface.IRepository;
using BankingSystem.Interface.IService;
using BankingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Domain.Service
{
    public class ManagerService : IManagerService
    {
        private readonly IManagerRepository _managerRepository;

        public  ManagerService(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }
        public Manager AddManager(Manager manager)
        {
            return _managerRepository.AddManager(manager);
        }

        public void DeleteManager(int id)
        {
            return _managerRepository.DeleteManager(id);
        }

        public List<Manager> GetAll()
        {
            return _managerRepository.GetAll(); ;
        }

        public Manager GetManager(int id)
        {
            return _managerRepository.GetManager(id);
        }

        public Manager UpdateManager(Manager manager)
        {
            return _managerRepository.UpdateManager(manager);
        }
    }
}
