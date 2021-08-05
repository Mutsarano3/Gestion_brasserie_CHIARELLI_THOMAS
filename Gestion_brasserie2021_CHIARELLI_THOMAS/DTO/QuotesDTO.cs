using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.DTO
{
	public class QuotesDTO
	{
		public List<ItemQuotesDTO> ItemQuotesDTOs { get; set; }

		public double TotalQuotes { get; set; }

		public QuotesDTO(List<ItemQuotesDTO> itemQuotesDTOs)
		{
			ItemQuotesDTOs = itemQuotesDTOs;
			foreach (var itemq in itemQuotesDTOs)
			{
				TotalQuotes += itemq.TotalPrice;
			}
		}
	}
}
