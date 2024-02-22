using Assignment.DataAccessLayer.Data;
using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DataAccessLayer.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        public ICategoryRepository CategoryRepository {get; private set;}

        public IProductRepository ProductRepository {get; private set;}

        public IPurchaseOrderRepository PurchaseOrderRepository {get; private set;}

        public IItemRepository POitemsRepository {get; private set;}

        public IDeliveryRepository DeliveryRepository {get; private set;}

        public IPurchaseOrderItemRepository DeliveryItemsRepository {get; private set;}

        public ICompanyRepository CompanyRepository {get; private set;}
        public IPurchaseOrderDeliveryItemRepository PurchaseOrderDeliveryItemRepository { get; private set; }

        private readonly ErpContext _erpContext;

        public UnitOfWork(ErpContext erpContext, ICategoryRepository categoryRepository, IProductRepository productRepository, IPurchaseOrderRepository purchaseOrderRepository, 
            IItemRepository poItemsRepository, IPurchaseOrderItemRepository deliveryItemsRepository, IDeliveryRepository deliveryRepository, 
            ICompanyRepository companyRepository, IPurchaseOrderDeliveryItemRepository purchaseOrderDeliveryItemRepository) 
        {
            this._erpContext = erpContext;
            this.CategoryRepository = categoryRepository;
            this.ProductRepository = productRepository;
            this.PurchaseOrderRepository = purchaseOrderRepository;
            this.POitemsRepository = poItemsRepository;
            this.DeliveryRepository = deliveryRepository;
            this.DeliveryItemsRepository = deliveryItemsRepository;
            this.CompanyRepository = companyRepository;
            this.PurchaseOrderDeliveryItemRepository = purchaseOrderDeliveryItemRepository;
        }
        
        public void Save()
        {
            _erpContext.SaveChanges();
        }
    }
}
