using BankingSystem.Interface.IRepository;
using BankingSystem.Models;
using BankingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingSystem.Domain.Repository
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly BankContext _bankContext;

        public ManagerRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public Manager AddManager(Manager manager)
        {
            _bankContext.Managers.Add(manager);
            _bankContext.SaveChanges();
            return manager;
        }

        public void DeleteManager(int id)
        {
            var manager = _bankContext.Managers.Find(id);
            if (manager != null)
            {
                _bankContext.Managers.Remove(manager);
                _bankContext.SaveChanges();
            }
        }

        public List<Manager> GetAll()
        {
            return _bankContext.Managers.ToList();
        }

        public Manager GetManager(int id)
        {
            var manager = _bankContext.Managers
                .Where(m => m.Id == id).FirstOrDefault();
            return manager;
        }

        public Manager UpdateManager(Manager manager)
        {
                _bankContext.Managers.Update(manager);
                _bankContext.SaveChanges();
                return manager;
            
        }
    }
}
