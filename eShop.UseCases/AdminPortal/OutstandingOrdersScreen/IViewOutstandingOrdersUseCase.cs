using e_Shop.CoreBusiness.Models;

namespace eShop.UseCases.AdminPortal.OutstandingOrdersScreen
{
	public interface IViewOutstandingOrdersUseCase
	{
		IEnumerable<Order> Execute();
	}
}