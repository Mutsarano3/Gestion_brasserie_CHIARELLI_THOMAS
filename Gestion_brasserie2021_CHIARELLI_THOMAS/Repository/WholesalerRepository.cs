using Gestion_brasserie2021_CHIARELLI_THOMAS.IRepository;
using Gestion_brasserie2021_CHIARELLI_THOMAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Repository
{
	public class WholesalerRepository  : GenericRepository<Wholesaler>, IWholesalerRepository
	{
		public WholesalerRepository(DataContext.DataContext context) : base(context)
		{

		}

		public List<Wholesaler> GetWholesalerByIdBeer(int id)
		{
			var beerwholesalers = _context.BeerWholesalers.Where(x => x.IdBeer == id).ToList();
			List<Wholesaler> wholesalers = new List<Wholesaler>();
			foreach(var beer in beerwholesalers)
			{
				var wholesaler = _context.Wholesalers.Where(x => x.Id == beer.IdWholesaler).SingleOrDefault();
				wholesalers.Add(wholesaler);
			}

			return wholesalers;
		}
	}
}
