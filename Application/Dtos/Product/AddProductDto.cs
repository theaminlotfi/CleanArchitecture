#nullable disable

using FluentValidation;

namespace Application.Dtos.Product;

public record AddProductDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int CategoryId { get; set; }
}

public class AddProductDtoValidator : AbstractValidator<AddProductDto>
{
    public AddProductDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is required.")
            .Length(1, 50)
            .WithMessage("Name must be between 1 and 50 characters.");

        RuleFor(x => x.Price)
            .NotEmpty()
            .WithMessage("Price is required.")
            .GreaterThan(0)
            .WithMessage("Price must be greater than zero.");

        RuleFor(x => x.Description)
            .Length(1, 500)
            .WithMessage("Description must be between 1 and 500 characters.");

        RuleFor(x => x.Quantity)
            .NotEmpty()
            .WithMessage("Stock is required.")
            .GreaterThan(0)
            .WithMessage("Stock must be greater than zero.");

        RuleFor(x => x.CategoryId)
            .NotEmpty()
            .WithMessage("Category is required.")
            .GreaterThan(0)
            .WithMessage("Category must be greater than zero.");
    }
}
