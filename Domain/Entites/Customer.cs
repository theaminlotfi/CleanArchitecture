#nullable disable

using Domain.Common;

namespace Domain.Entites;

public class Customer : BaseEntity<int>
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    // Navigation property
    public ICollection<Order> Orders { get; set; }

    private Customer() { }

    public Customer(int customerId, string firstName, string lastName, string email, string phone, ICollection<Order> orders)
    {
        CustomerId = customerId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Orders = orders;
    }
}
