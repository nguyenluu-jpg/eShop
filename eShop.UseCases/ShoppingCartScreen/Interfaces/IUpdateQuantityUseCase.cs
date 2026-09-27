using e_Shop.CoreBusiness.Models;

namespace eShop.UseCases.ShoppingCartScreen.Interfaces
{
    public interface IUpdateQuantityUseCase
    {
        Task<Order> Execute(int productId, int quantity);
    }
}