namespace Assignment.DataAccessLayer.Infrastructure.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        IPurchaseOrderRepository PurchaseOrderRepository { get; }
        IItemRepository POitemsRepository { get; }
        IDeliveryRepository DeliveryRepository { get; }
        IPurchaseOrderItemRepository DeliveryItemsRepository { get; }
        ICompanyRepository  CompanyRepository { get; }
        IPurchaseOrderDeliveryItemRepository PurchaseOrderDeliveryItemRepository { get; }
        
        void Save();
    }
}
