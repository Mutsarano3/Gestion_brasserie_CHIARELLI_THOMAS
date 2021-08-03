using Gestion_brasserie2021_CHIARELLI_THOMAS.IRepository;
using Gestion_brasserie2021_CHIARELLI_THOMAS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		public IBeerRepository Beers { get; private set; }

		public IBrewerRepository Brewers { get; private set; }

		public IWholesalerRepository Wholesalers { get; private set; }

		private readonly DataContext.DataContext _context;

        public UnitOfWork(DataContext.DataContext context)
        {
            _context = context;
			Beers = new BeerRepository(_context);
			Brewers = new BrewerRepositorycs(_context);
			Wholesalers = new WholesalerRepository(_context);
        }

        public int Complete()
		{
			return _context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
