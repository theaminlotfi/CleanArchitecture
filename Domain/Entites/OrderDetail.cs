#nullable disable

using Domain.Common;

namespace Domain.Entites;

public class OrderDetail : BaseEntity<int>
{
    public int OrderDetailId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    // Foreign Key
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    // Navigation property    
    public Order Order { get; set; }
    public Product Product { get; set; }

    private OrderDetail() { }

    public OrderDetail(int orderDetailId, int quantity, decimal unitPrice, int orderId, int productId, Order order, Product product)
    {
        OrderDetailId = orderDetailId;
        Quantity = quantity;
        UnitPrice = unitPrice;
        OrderId = orderId;
        ProductId = productId;
        Order = order;
        Product = product;
    }
}
