using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Models
{
	public abstract class Entity
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public virtual int Id { get; set; }

	}
}
