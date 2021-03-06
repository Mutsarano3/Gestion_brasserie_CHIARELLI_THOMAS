using Gestion_brasserie2021_CHIARELLI_THOMAS.IRepository;
using Gestion_brasserie2021_CHIARELLI_THOMAS.Repository;
using Gestion_brasserie2021_CHIARELLI_THOMAS.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllers();
			services.AddDbContext<DataContext.DataContext>(x => x.UseSqlServer(Configuration.GetConnectionString("local_connection_string")));
			services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			services.AddTransient<IBeerRepository, BeerRepository>();
			services.AddTransient<IBrewerRepository, BrewerRepository>();
			services.AddTransient<IWholesalerRepository, WholesalerRepository>();
			services.AddTransient<IBeerWholesalerRepository, BeerWholesalerRepository>();
			services.AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseHttpsRedirection();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
