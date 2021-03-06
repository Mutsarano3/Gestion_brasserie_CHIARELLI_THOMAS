using Gestion_brasserie2021_CHIARELLI_THOMAS.IRepository;
using Gestion_brasserie2021_CHIARELLI_THOMAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Repository
{
	public class BeerWholesalerRepository : GenericRepository<BeerWholesaler>, IBeerWholesalerRepository
	{
		public BeerWholesalerRepository(DataContext.DataContext context) : base(context)
		{

		}

		public BeerWholesaler GetBeerWholesalerByIdBeerAndIdWholesaler(int idbeer,int idwholesaler)
		{
			var beerwholesaler = _context.BeerWholesalers.ToList().Where(x => x.IdBeer == idbeer && x.IdWholesaler == idwholesaler).SingleOrDefault();

			return beerwholesaler;
		}

		public List<BeerWholesaler> GetBeerWholesalersByIdWholesaler(int id)
		{
			List<BeerWholesaler> beerWholesalers = _context.BeerWholesalers.Where(x => x.IdWholesaler == id).ToList();

			return beerWholesalers;
		}
	}
}
