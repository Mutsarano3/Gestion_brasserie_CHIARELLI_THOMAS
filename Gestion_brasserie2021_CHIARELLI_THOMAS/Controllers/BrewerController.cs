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
	[Route("api/brewer")]
	[ApiController]
	public class BrewerController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;
		public BrewerController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		[HttpPost]
		[Route("newbeer")]
		public ActionResult NewBeer(Beer beer)
		{
			if (beer == null)
			{
				return BadRequest("No beer was sent");
			}

			if (string.IsNullOrEmpty(beer.Name))
			{
				return BadRequest("No names have been sent");
			}

			_unitOfWork.Beers.SaveOrUpdate(beer);
			_unitOfWork.Complete();
			return Created("", beer);
		}

		[HttpDelete]
		[Route("deletebeer/{id}")]
		public ActionResult DeleteBeer(int id)
		{
			Beer beer = _unitOfWork.Beers.GetById(id);

			if (beer == null)
			{
				return NotFound("No beer was found");
			}

			_unitOfWork.Beers.Remove(beer);
			_unitOfWork.Complete();

			return NoContent();
		}

		[HttpGet]
		[Route("getAllbeer")]
		public ActionResult GetAllBeer()
		{
			List<Beer> beers = _unitOfWork.Beers.GetAll();

			foreach (var b in beers)
			{
				var bewer = _unitOfWork.Brewers.GetById(b.IdBrewer);
				b.Brewer = bewer;
			}

			return Ok(beers);
		}

		[HttpPost]
		[Route("addNewbeeratwholesaler")]
		public ActionResult AddBeerWholesaler(BeerWholesaler beerWholesaler)
		{
			if (beerWholesaler == null)
			{
				return BadRequest("No data has been sent");
			}

			var beer = _unitOfWork.Beers.GetById(beerWholesaler.IdBeer);
			var wholesaler = _unitOfWork.Wholesalers.GetById(beerWholesaler.IdWholesaler);
			if (beer == null || wholesaler == null)
			{
				string message = "";

				if (wholesaler == null && beer == null)
				{
					message = "The beer and the wholesaler was not found";
				}

				else if (beer == null)
				{
					message = "No beer was found";
				}
				else if (wholesaler == null)
				{
					message = "No wholesalers were found";
				}

				return NotFound(message);
			}

			_unitOfWork.BeerWholesalers.SaveOrUpdate(beerWholesaler);
			_unitOfWork.Complete();

			return Created("", beerWholesaler);
		}

		[HttpPut]
		[Route("updateQuantityBeer")]
		public ActionResult UpdateQuantityBeer(BeerWholesaler beerWholesaler)
		{
			if (beerWholesaler == null)
			{
				return BadRequest("No data has been sent");
			}

			var beer = _unitOfWork.Beers.GetById(beerWholesaler.IdBeer);
			var wholesaler = _unitOfWork.Wholesalers.GetById(beerWholesaler.IdWholesaler);
			if (beer == null || wholesaler == null)
			{
				string message = "";

				if (wholesaler == null && beer == null)
				{
					message = "The beer and the wholesaler was not found";
				}

				else if (beer == null)
				{
					message = "No beer was found";
				}
				else if (wholesaler == null)
				{
					message = "No wholesalers were found";
				}

				return NotFound(message);
			}

			var oldbeerwholesaler = _unitOfWork.BeerWholesalers.GetBeerWholesalerByIdBeerAndIdWholesaler(beer.Id, wholesaler.Id);
			oldbeerwholesaler.BeerQuantity = beerWholesaler.BeerQuantity;
			_unitOfWork.BeerWholesalers.SaveOrUpdate(oldbeerwholesaler);
			_unitOfWork.Complete();

			return NoContent();





		}
	}
}
