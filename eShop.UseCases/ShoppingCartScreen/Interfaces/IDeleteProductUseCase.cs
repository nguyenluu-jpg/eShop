using e_Shop.CoreBusiness.Models;

namespace eShop.UseCases.ShoppingCartScreen
{
    public interface IDeleteProductUseCase
    {
        Task<Order> Execute(int productId);
    }
}