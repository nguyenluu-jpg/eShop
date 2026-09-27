using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_Shop.CoreBusiness.Models;
using e_Shop.CoreBusiness.Serrvices.interfaces;

namespace e_Shop.CoreBusiness.Serrvices
{
    public class OrderService : IOrderService
    {
        // kiểm tra đơn hàng 
        public bool ValidateCustomerInformation(string name, string city, string address, string provice, string country)
        {
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(provice) ||
                string.IsNullOrWhiteSpace(country))
            {
                return false;

            }
            return true;
        }

        public bool ValidateCreateOrder(Order order)
        {
            // phải tồn tại 1 order
            if (order == null)
                return false;

            // order ít nhất phải ó line items 
            if (order.LineItems == null || order.LineItems.Count <= 0) return false;

            // Xem xét xử lý line items - kiểm tra từng mặt hàng một 
            foreach (var item in order.LineItems)
            {
                if (item.ProductId <= 0 || item.Price < 0 || item.Quantity <= 0) return false;
            }
            // validate customer info: thông tin khách hàng
            if (!ValidateCustomerInformation(order.CustomerName, order.CustomerAddress, order.CustomerCity,
                order.CustomerStateProvince, order.CustomerCountry))
                return false;
            return true;
        }
        public bool ValidateUpdateOrder(Order order)
        {
            if (order == null) return false;
            if (!order.OrderId.HasValue) return false;

            // order has to have order line items
            if (order.LineItems == null || order.LineItems.Count <= 0) return false;

            // Placed Date has to be populated
            if (!order.DateProcessed.HasValue) return false;

            // Valiate uniqurId
            if (order.DateProcessed.HasValue || order.DateProcessing.HasValue) return false;

            if (string.IsNullOrEmpty(order.CustomerName)) return false;

            foreach (var item in order.LineItems)
            {
                if (item.ProductId <= 0 || item.Price < 0 || item.Quantity <= 0 || item.OrderId == order.OrderId) return false;

            }
            // validate customer info: thông tin khách hàng
            if (!ValidateCustomerInformation(order.CustomerName, order.CustomerAddress, order.CustomerCity,
                order.CustomerStateProvince, order.CustomerCountry))
                return false;
            return false;
        }

        // xem mặt hàng đúng chưa và nếu đúng thì mới ship - thường làm cho sàn thương mại điện tử
        public bool ValidateProcessOrder(Order order)
        {
            if (!order.DateProcessed.HasValue || string.IsNullOrWhiteSpace(order.AdminUser)) return false;
            return true;
        }
    }

}
