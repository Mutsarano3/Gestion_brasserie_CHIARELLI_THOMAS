using Gestion_brasserie2021_CHIARELLI_THOMAS.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
        IBeerRepository Beers { get; }
        IBrewerRepository Brewers { get; }
        IWholesalerRepository Wholesalers { get; }
        IBeerWholesalerRepository BeerWholesalers { get; }
        int Complete();
    }
}
