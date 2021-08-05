using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.DTO
{
	public class QuotesDTO
	{
		public List<OrderDTO> Orders { get; set; }

		public double TotalQuotes { get; set; }

		public QuotesDTO(List<OrderDTO> orderDTOs)
		{
			Orders = orderDTOs;
			foreach (var oDTO in orderDTOs)
			{
				TotalQuotes += oDTO.TotalPrice;
			}
		}
	}
}
