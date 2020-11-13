using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Data.Repositories;
using ShoppingCart.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ShoppingCart.Application.Services
{
	public class ProductsService : IProductsService
	{
		private IProductsRepository _productsRepo;

		public ProductsService(IProductsRepository productsRepository) {
			_productsRepo = productsRepository;
		}

		public IQueryable<ProductViewModel> GetProducts() {

			//IProductsRepository repo = new ProductsRepository(xxx);

			//To Be Impletmented using AutoMapper

			var list = from p in _productsRepo.GetProducts()
					   select new ProductViewModel()
					   {Id = p.Id,
						Description = p.Description,
					    Name = p.Name,
					    Price = p.Price,
					    Category = new CategoryViewModel() {Id = p.Category.Id, Name = p.Category.Name }
					   };

			return list;
		}

		public IQueryable<ProductViewModel> GetProducts(int category)
		{
			//IProductsRepository repo = new ProductsRepository(xxx);

			var list = from p in _productsRepo.GetProducts().Where(x => x.Category.Id == category)
					   select new ProductViewModel()
					   {
						   Id = p.Id,
						   Description = p.Description,
						   Name = p.Name,
						   Price = p.Price,
						   Category = new CategoryViewModel() { Id = p.Category.Id, Name = p.Category.Name }
					   };

			return list;
		}
	}
}
