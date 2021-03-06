using Gestion_brasserie2021_CHIARELLI_THOMAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.IRepository
{
	public interface IBeerWholesalerRepository : IGenericRepository<BeerWholesaler>
	{
		public BeerWholesaler GetBeerWholesalerByIdBeerAndIdWholesaler(int idbeer, int idwholesaler);
		public List<BeerWholesaler> GetBeerWholesalersByIdWholesaler(int id);
		
	}
}
