using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Models
{
	public class BeerWholesaler : Entity
	{
		public int IdBeer { get; set; }

		public int IdWholesaler { get; set; }

		public int BeerQuantity { get; set; }

		[ForeignKey("IdBeer")]
		public virtual Brewer Brewer { get; set; }

		[ForeignKey("IdWholesaler")]
		public virtual Wholesaler Wholesaler { get; set; }


	}
}
