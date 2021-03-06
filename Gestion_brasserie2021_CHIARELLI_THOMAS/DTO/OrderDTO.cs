using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.DTO
{
	public class OrderDTO
	{
		public string BeerName { get; set; }

		public decimal PriceUnitary { get; set; }

		public int Quantity { get; set; }

		public decimal TotalPrice { get; set; }

		public OrderDTO(string beername, decimal price_unitary,int quantity)
		{
			BeerName = beername;
			PriceUnitary = price_unitary;
			Quantity = quantity;
			TotalPrice = price_unitary * quantity;
		}


	}
}
