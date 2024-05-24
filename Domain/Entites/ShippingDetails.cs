#nullable disable

using Domain.Common;

namespace Domain.Entites;

public class ShippingDetails : BaseEntity<int>
{
    public int ShippingId { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    // Foregin Key
    public int OrderId { get; set; }
    // Navigation property
    public Order Order { get; set; }

    private ShippingDetails() { }

    public ShippingDetails(int shippingId, string address, string city, string region, string postalCode, int orderId, Order order)
    {
        ShippingId = shippingId;
        Address = address;
        City = city;
        Region = region;
        PostalCode = postalCode;
        OrderId = orderId;
        Order = order;
    }
}
