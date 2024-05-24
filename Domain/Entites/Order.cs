#nullable disable

using Domain.Common;
using Domain.Enums;

namespace Domain.Entites;

public class Order : BaseEntity<int>
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }
    public decimal TotalAmount { get; set; }
    // Foreign Key
    public int CustomerId { get; set; }
    // Navigation property
    public Customer Customer { get; set; }
    public ICollection<OrderDetail> Details { get; set; }
    public ShippingDetails ShippingDetails { get; set; }

    private Order() { }

    public Order(int orderId, DateTime orderDate, OrderStatus status, decimal totalAmount, int customerId, Customer customer, ICollection<OrderDetail> details, ShippingDetails shippingDetails)
    {
        OrderId = orderId;
        OrderDate = orderDate;
        Status = status;
        TotalAmount = totalAmount;
        CustomerId = customerId;
        Customer = customer;
        Details = details;
        ShippingDetails = shippingDetails;
    }
}
