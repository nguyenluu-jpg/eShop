using e_Shop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.SearchProductScreen
{
    public interface ISearchProductUseCase
    {
		IEnumerable<Product> Execute(string filter); // tìm kiếm một từ khóa và trả về một loạt danh sách 
	}
}
