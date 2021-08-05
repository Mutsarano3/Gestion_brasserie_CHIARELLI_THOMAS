using Gestion_brasserie2021_CHIARELLI_THOMAS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.IRepository
{
	public interface IWholesalerRepository : IGenericRepository<Wholesaler>
	{
		public List<Wholesaler> GetWholesalerByIdBeer(int id);
	}
}
