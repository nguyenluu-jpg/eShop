using e_Shop.CoreBusiness.Models;

namespace e_Shop.CoreBusiness.Serrvices.interfaces
{
    public interface IOrderService
    {
        bool ValidateCreateOrder(Order order);
        bool ValidateCustomerInformation(string name, string city, string address, string provice, string country);
        bool ValidateProcessOrder(Order order);
        bool ValidateUpdateOrder(Order order);
    }
}