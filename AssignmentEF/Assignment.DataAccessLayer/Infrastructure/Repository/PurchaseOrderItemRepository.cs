using Assignment.DataAccessLayer.Data;
using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DataAccessLayer.Infrastructure.Repository
{
    public class PurchaseOrderItemRepository : Repository<PurchaseOrderDeliveryItem>, IPurchaseOrderItemRepository 
    {
        public PurchaseOrderItemRepository(ErpContext context) : base(context)
        {
            
        }
    }
}
