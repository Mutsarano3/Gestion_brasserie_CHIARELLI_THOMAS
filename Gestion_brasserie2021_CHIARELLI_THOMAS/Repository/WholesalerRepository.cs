﻿using Gestion_brasserie2021_CHIARELLI_THOMAS.IRepository;
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
	}
}
