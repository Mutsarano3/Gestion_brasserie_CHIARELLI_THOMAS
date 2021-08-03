using Gestion_brasserie2021_CHIARELLI_THOMAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.IRepository
{
	public interface IGenericRepository<T> where T : Entity
	{
        T GetById(int id);
        List<T> GetAll();
        T Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        T SaveOrUpdate(T entity);
    }
}
