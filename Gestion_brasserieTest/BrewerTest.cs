using Gestion_brasserie2021_CHIARELLI_THOMAS;
using Gestion_brasserie2021_CHIARELLI_THOMAS.Controllers;
using Gestion_brasserie2021_CHIARELLI_THOMAS.DataContext;
using Gestion_brasserie2021_CHIARELLI_THOMAS.IRepository;
using Gestion_brasserie2021_CHIARELLI_THOMAS.Models;
using Gestion_brasserie2021_CHIARELLI_THOMAS.Repository;
using Gestion_brasserie2021_CHIARELLI_THOMAS.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace Gestion_brasserieTest
{
	[TestClass()]
	public class BrewerTest
	{
		

		





		[TestMethod()]
		public  void AddBeer()
		{
			Beer beer = new Beer();
			beer.IdBrewer = 1;
			beer.Name = "TestLeffe";
			beer.Price = 12.2;
			beer.Alchool = 5.2;

			/*var mockContext  = new Mock<UnitOfWork>();
			mockContext.Setup(m => m.Beers.SaveOrUpdate(beer)).Returns(beer);
			var controller = new BrewerController(mockContext.Object);
			*/
			/*

			Beer beer = new Beer();
			beer.IdBrewer = 1;
			beer.Name = "TestLeffe";
			beer.Price = 12.2;
			beer.Alchool = 5.2;
		
			
			//Assert.AreEqual("ok", "ok");
			
			
			if (beer == null)
			{
				
			}

			if (string.IsNullOrEmpty(beer.Name))
			{
				
			}

			_unitOfWork.Beers.SaveOrUpdate(beer);
			_unitOfWork.Complete();
			Assert.AreEqual("ok", "ok");
			*/





		}
	}
}


