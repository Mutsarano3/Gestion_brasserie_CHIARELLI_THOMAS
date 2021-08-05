using Gestion_brasserie2021_CHIARELLI_THOMAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.DataContext
{
	public class DataContext : DbContext
	{
		public DbSet<Beer> Beers { get; set; }

		public DbSet<Brewer> Breweries { get; set; }

		public DbSet<Wholesaler> Wholesalers { get; set; }

		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Brewer>().HasData(new Brewer(1, "Test"));
			builder.Entity<Wholesaler>().HasData(new Wholesaler(1, "TestGrossiste"));
		}


	}
}
