using ApiRestBilling.Models;

namespace ApiRestBilling2.Service
{
 
    public interface IPurchaseOrdersService
    {
        Task<decimal> CheckUnitPrice(OrderItem detalle);
        Task<decimal> CalculateSubtotalOrderItem(OrderItem item);
        decimal CalculateTotalOrderItems(List<OrderItem> item);
    }
}

