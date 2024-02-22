using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.DataAccessLayer.Infrastructure.Repository;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
namespace AssignmentEF
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddIUnitOfWork(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICategoryRepository, CategoryRepository>();
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
            serviceCollection.AddScoped<IPurchaseOrderRepository, PurchaseOrderRepository>();
            serviceCollection.AddScoped<IItemRepository, ItemRepository>();
            serviceCollection.AddScoped<ICompanyRepository, CompanyRepository>();
            serviceCollection.AddScoped<IDeliveryRepository, DeliveryRepository>();
            serviceCollection.AddScoped<IPurchaseOrderItemRepository, PurchaseOrderItemRepository>();
            serviceCollection.AddScoped<IPurchaseOrderDeliveryItemRepository, PurchaseOrderDeliveryItemRepository>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            return serviceCollection;
        }
    }
}
