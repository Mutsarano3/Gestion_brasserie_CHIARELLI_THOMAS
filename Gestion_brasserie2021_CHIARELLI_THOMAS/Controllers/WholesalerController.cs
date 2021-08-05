using Gestion_brasserie2021_CHIARELLI_THOMAS.DTO;
using Gestion_brasserie2021_CHIARELLI_THOMAS.Models;
using Gestion_brasserie2021_CHIARELLI_THOMAS.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Controllers
{
	[Route("api/wholesaler")]
	[ApiController]
	public class WholesalerController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public WholesalerController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}


		[HttpPost]
		[Route("askquotes/{id}")]
		public ActionResult AskQuotes(int id,List<BeerWholesaler> order)
		{
			List<OrderDTO> itemQuotes = new List<OrderDTO>();
			if(order.Count == 0)
			{
				return BadRequest("La commande ne peut-être vide");
			}

			var wholesaler = _unitOfWork.Wholesalers.GetById(id);
			if(wholesaler == null)
			{
				return NotFound("Le grossiste n'exitse pas");
			}


			List<BeerWholesaler> beerWholesalers = _unitOfWork.BeerWholesalers.GetBeerWholesalersByIdWholesaler(id);

			foreach(var o in order)
			{
				o.IdWholesaler = id;
				
				if(order.Where(x => x.IdBeer == o.IdBeer && x.IdWholesaler == o.IdWholesaler && x.BeerQuantity == o.BeerQuantity).ToList().Count >= 2)
				{
					return BadRequest("Un doublon à été trouvé dans la commande");
				}

				if(beerWholesalers.Where(bh => bh.BeerQuantity < o.BeerQuantity).SingleOrDefault() != null)
				{
					return BadRequest("Le grossiste " + wholesaler.Name + " n'a  pas assez de stocke.");
				}

				var test = beerWholesalers.FindAll(x => x.IdBeer != o.IdBeer);

				if (beerWholesalers.FindAll(x => x.IdBeer != o.IdBeer).ToList().Count > 0)
				{
					return BadRequest("Le grossiste ne vend pas cette bière");
				}

				var beer = _unitOfWork.Beers.GetById(o.IdBeer);
				itemQuotes.Add(new OrderDTO(beer.Name, (decimal)beer.Price, o.BeerQuantity));

			}

			QuotesDTO quotesDTO = new QuotesDTO(itemQuotes);

			return Ok(quotesDTO);


			
		}
	}
}
