using Gestion_brasserie2021_CHIARELLI_THOMAS.IRepository;
using Gestion_brasserie2021_CHIARELLI_THOMAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Repository
{
	public class GenericRepository<T> : IGenericRepository<T> where T : Entity
	{

		protected readonly DataContext.DataContext _context;

		public GenericRepository(DataContext.DataContext context)
		{
			_context = context;
		}


		public T Add(T entity)
		{
			return _context.Set<T>().Add(entity).Entity;
		}

		public void AddRange(IEnumerable<T> entities)
		{
			_context.Set<T>().AddRange(entities);
		}

		public List<T> GetAll()
		{
			return  _context.Set<T>().ToList();
		}


		public T GetById(int id)
		{
			return  _context.Set<T>().Find(id);
		}

		public void Remove(T entity)
		{
			_context.Set<T>().Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entities)
		{
			_context.Set<T>().RemoveRange(entities);
		}

		public T SaveOrUpdate(T entity)
		{
			if (entity.Id == 0)
			{
				return Add(entity);
			}
			else
			{
				Update(entity);
				return null;
			}
		}

		public void Update(T entity)
		{
			_context.Entry(entity).State = EntityState.Modified;
		}
	}
}
