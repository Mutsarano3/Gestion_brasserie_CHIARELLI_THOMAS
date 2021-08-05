using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.DTO
{
	public class QuotesDTO
	{
		public List<OrderDTO> Orders { get; set; }

		public decimal TotalQuotes { get; set; }
		public int TotalQuantity { get; set; }

		public QuotesDTO(List<OrderDTO> orderDTOs)
		{
			Orders = orderDTOs;
			foreach (var oDTO in orderDTOs)
			{
				TotalQuantity += oDTO.Quantity;
				TotalQuotes += oDTO.TotalPrice;
			}

			if (TotalQuantity > 20)
			{
				TotalQuotes = TotalQuotes - (TotalQuotes / 100) * 20;
			}
			else if (TotalQuantity > 10)
			{
				TotalQuotes = TotalQuotes - (TotalQuotes / 100) * 10;
			}
			
		}
	}
}
