using e_Shop.CoreBusiness.Models;
using e_Shop.CoreBusiness.Serrvices;
using e_Shop.CoreBusiness.Serrvices.interfaces;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.PluginInterfaces.StateStore;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.UseCases.ShoppingCartScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.ShoppingCartScreen
{
    public class PlaceOrderUseCase : IPlaceOrderUseCase
    {
        private readonly IOrderService orderService;
        private readonly IOrderRepository orderRepository;
        private readonly IShoppingCartStateStore shoppingCartStateStore;
        private readonly IShoppingCart shoppingCart;
        public PlaceOrderUseCase(
            IOrderService orderService,
            IOrderRepository orderRepository,
            IShoppingCart shoppingCart,
            IShoppingCartStateStore shoppingCartStateStore)
        {
            this.orderService = orderService;
            this.orderRepository = orderRepository;
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }
        public async Task<string> Execute(Order order)
        {
            if (orderService.ValidateCreateOrder(order))
            {
                order.DatePlaced = DateTime.Now;
                order.UniqueId = Guid.NewGuid().ToString();
                orderRepository.CreateOrder(order);

                await shoppingCart.EmptyAsync();
                shoppingCartStateStore.UpdateLineItemsCount();
                return order.UniqueId;
            }
            return null;
        }
    }
}
