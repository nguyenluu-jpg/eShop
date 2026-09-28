// using eShop.DataStore.HardCoded;
using eShop.DataStore.SQL.Dapper;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.ViewProductScreen;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using eShop.Web.Components;
using eShop.UseCases.SearchProductScreen;
using eShop.UseCases.ViewProductScreen.interfaces;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.ShoppingCart.LoaclStorage;
using eShop.UseCases.ShoppingCartScreen.Interfaces;
using eShop.UseCases.ShoppingCartScreen;
using eShop.UseCases.PluginInterfaces.StateStore;
using eShop.StateStore.DI;
using e_Shop.CoreBusiness.Serrvices.interfaces;
using e_Shop.CoreBusiness.Serrvices;
using eShop.UseCases.OrderConfirmationScreen;
using eShop.UseCases.AdminPortal.OutstandingOrdersScreen;
using eShop.UseCases.AdminPortal.OrderDetailScreen.Interfaces;
using eShop.UseCases.AdminPortal.OrderDetailScreen;
using eShop.UseCases.AdminPortal.ProcessedOrdersScreen;
using eShop.DataStore.SQL.Dapper.Helpers;

namespace eShop.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddAuthentication("eShop.CookieAuth")
                .AddCookie("eShop.CookieAuth", config =>
                {
                    config.Cookie.Name = "eShop.CookieAuth";
                    config.LoginPath = "/authenticate";
                });
            builder.Services.AddAuthorization();
            builder.Services.AddCascadingAuthenticationState();
            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
   //         builder.Services.AddSingleton<IProductRepository, ProductRepository>();
			//builder.Services.AddSingleton<IOrderRepository, OrderRepository>();

			builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddScoped<IShoppingCart, eShop.ShoppingCart.LoaclStorage.ShoppingCart>();
            builder.Services.AddScoped<IShoppingCartStateStore, ShoppingCartStateStore>();

            builder.Services.AddTransient<IDataAccess>(sp => new DataAccess(builder.Configuration.GetConnectionString("Default")));
			builder.Services.AddTransient<IProductRepository, ProductRepository>();
			builder.Services.AddTransient<IOrderRepository, OrderRepository>();


			builder.Services.AddTransient<IOrderService, OrderService>();
			builder.Services.AddTransient<IViewProductUseCase, ViewProductUseCase>();
            builder.Services.AddTransient<ISearchProductUseCase, SearchProductUseCase>();
            builder.Services.AddTransient<IAddProductToCartUseCase, AddProductToCartUseCase>();
			builder.Services.AddTransient<IViewShoppingCartUseCase, ViewShoppingCartUseCase>();
            builder.Services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
            builder.Services.AddTransient<IUpdateQuantityUseCase, UpdateQuantityUseCase>();
            builder.Services.AddTransient<IPlaceOrderUseCase, PlaceOrderUseCase>();
            builder.Services.AddTransient<IViewOrderConfirmationUseCase, ViewOrderConfirmationUseCase>();

			builder.Services.AddTransient<IViewOutstandingOrdersUseCase, ViewOutstandingOrdersUseCase>();
			builder.Services.AddTransient<IViewOrderDetailUseCase, ViewOrderDetailUseCase>();
			builder.Services.AddTransient<IProcessOrderUseCase, ProcessOrderUseCase>();
			builder.Services.AddTransient<IViewProcessedOrdersUseCase, ViewProcessedOrdersUseCase>();



			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

			app.MapRazorComponents<App>()
				.AddInteractiveServerRenderMode()
				.AddAdditionalAssemblies(
					typeof(eShop.Web.CustomerPortal.Pages.SearchProductComponent).Assembly,
					typeof(eShop.Web.AdminPortal.Pages.OutstandingOrdersComponent).Assembly)
				.AllowAnonymous();
			app.Run();
        }
    }
}
