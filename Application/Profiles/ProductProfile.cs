using Application.Dtos.Product;
using AutoMapper;
using Domain.Entites;

namespace Application.Profiles;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        // AddProductDto to Product mapping
        CreateMap<AddProductDto, Product>()
            .ForAllMembers(opt => opt.Ignore());

        // Product to AddProductDto mapping
        CreateMap<Product, AddProductDto>()
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.CategoryId));

        // UpdateProductDto to Product mapping
        CreateMap<UpdateProductDto, Product>()
            .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
            .ForAllMembers(opt => opt.Ignore());

        // Product to UpdateProductDto mapping
        CreateMap<Product, UpdateProductDto>()
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.CategoryId));

        // Product to ProductDto mapping
        CreateMap<Product, ProductDto>()
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.CategoryId));

        // ProductDto to Product mapping
        CreateMap<ProductDto, Product>()
            .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
            .ForAllMembers(opt => opt.Ignore());
    }
}
