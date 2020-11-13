using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Domain.Interfaces;
using Stripe;
using System;

namespace ShoppingCart.IOC
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			services.AddScoped<IProductsRepository, IProductsRepository>();
			services.AddScoped<IProductsService, ProductService>();
		}
	}
}
