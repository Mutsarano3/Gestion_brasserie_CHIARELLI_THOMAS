using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.DTO
{
	public class ItemQuotesDTO
	{
		public string BeerName { get; set; }

		public double PriceUnitary { get; set; }

		public int Quantity { get; set; }

		public double TotalPrice { get; set; }

		public ItemQuotesDTO(string beername,double price_unitary,int quantity)
		{
			BeerName = beername;
			PriceUnitary = price_unitary;
			Quantity = quantity;
			TotalPrice = price_unitary * quantity;
		}


	}
}
