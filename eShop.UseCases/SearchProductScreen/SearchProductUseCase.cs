using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Shop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.UseCases.SearchProductScreen
{
    public class SearchProductUseCase : ISearchProductUseCase
    {
		private readonly IProductRepository productRepository;

		public SearchProductUseCase(IProductRepository productRepository)
		{
			this.productRepository = productRepository;
		}

		public IEnumerable<Product> Execute(string filter)
		{
			return productRepository.GetProducts(filter);
		}
	}
}
