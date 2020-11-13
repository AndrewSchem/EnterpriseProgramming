using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingCart.Application.ViewModels
{
	public class CategoryViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
