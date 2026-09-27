using e_Shop.CoreBusiness.Models;

namespace eShop.UseCases.ShoppingCartScreen.Interfaces
{
    public interface IPlaceOrderUseCase
    {
        Task<string> Execute(Order order);
    }
}