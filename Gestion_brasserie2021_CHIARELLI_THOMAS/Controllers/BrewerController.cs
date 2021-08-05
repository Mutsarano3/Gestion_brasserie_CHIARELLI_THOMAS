using Gestion_brasserie2021_CHIARELLI_THOMAS.UnitOfWork;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Controllers
{
	[Route("api/admin")]
	[ApiController]
	public class BrewerController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;
		public BrewerController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}



	}
}
