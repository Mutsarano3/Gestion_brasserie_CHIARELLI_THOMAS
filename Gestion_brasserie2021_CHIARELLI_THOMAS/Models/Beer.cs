using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Models
{
	public class Beer : Entity
	{
		public string Name { get; set; }

		public double Alchool { get; set; }

		public double Price { get; set; }


		 public int IdBrewer {  get; set; }

		[ForeignKey("IdBrewer")]
		public virtual Brewer Brewer { get; set; }

		[NotMapped]
		public List<Wholesaler> Wholesalers { get; set; }
	}
}
