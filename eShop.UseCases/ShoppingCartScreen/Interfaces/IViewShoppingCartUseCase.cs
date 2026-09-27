using e_Shop.CoreBusiness.Models;

namespace eShop.UseCases.ShoppingCartScreen.Interfaces
{
    public interface IViewShoppingCartUseCase
    {
        Task<Order> Execute();
    }
}