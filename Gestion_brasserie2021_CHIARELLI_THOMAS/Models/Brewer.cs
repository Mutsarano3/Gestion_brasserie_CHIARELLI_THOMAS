using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Models
{
	public class Brewer : Entity
	{
		public string Name { get; set; }

		public Brewer(int id,string name)
		{
			Id = id;
			Name = name;

		}

	}
}
