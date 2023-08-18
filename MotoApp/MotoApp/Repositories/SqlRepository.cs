using Microsoft.EntityFrameworkCore;
using MotoApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoApp.Repositories
{
    public class SqlRepository
    {
        private readonly DbSet<Employee> _dbSet;
        private readonly DbContext _dbContext;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<Employee>();
        }
        public Employee? GetById(int Id)
        {
            return _dbSet.Find(Id);
        }

        public void Add (Employee item)
        {
            _dbSet.Add(item);
        }
        public void Remove(Employee item)
        {
            _dbSet.Remove(item);
        }

        public void Save()
        {
           _dbContext.SaveChanges();
        }


    }
}
