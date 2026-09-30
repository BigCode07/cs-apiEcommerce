using ApiEcommerce.Models;
using ApiEcommerce.Models.Dtos;
using Mapster;

namespace ApiEcommerce.Mapping;

public class MappingConfig : IRegister
{
  public void Register(TypeAdapterConfig config)
  {
    // AutoMapper ignoraba mayúsculas/minúsculas (UserName -> Username); Mapster no
    config.Default.NameMatchingStrategy(NameMatchingStrategy.IgnoreCase);

    // Category
    config.NewConfig<Category, CategoryDto>();
    config.NewConfig<CategoryDto, Category>();
    config.NewConfig<Category, CreateCategoryDto>();
    config.NewConfig<CreateCategoryDto, Category>();

    // Product
    config.NewConfig<Product, ProductDto>()
      .Map(dest => dest.CategoryName, src => src.Category.Name);
    config.NewConfig<ProductDto, Product>()
      .Ignore(dest => dest.Category);
    config.NewConfig<Product, CreateProductDto>();
    config.NewConfig<CreateProductDto, Product>();
    config.NewConfig<Product, UpdateProductDto>();
    config.NewConfig<UpdateProductDto, Product>();

    // User
    config.NewConfig<User, UserDto>();
    config.NewConfig<UserDto, User>();
    config.NewConfig<User, CreateUserDto>();
    config.NewConfig<CreateUserDto, User>();
    config.NewConfig<User, UserLoginDto>();
    config.NewConfig<UserLoginDto, User>();
    config.NewConfig<User, UserLoginResponseDto>();
    config.NewConfig<UserLoginResponseDto, User>();
    config.NewConfig<ApplicationUser, UserDataDto>();
    config.NewConfig<UserDataDto, ApplicationUser>();
    config.NewConfig<ApplicationUser, UserDto>();
    config.NewConfig<UserDto, ApplicationUser>();
  }
}
