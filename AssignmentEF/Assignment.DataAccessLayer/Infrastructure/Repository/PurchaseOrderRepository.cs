using Assignment.DataAccessLayer.Data;
using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DataAccessLayer.Infrastructure.Repository
{
    public class PurchaseOrderRepository :Repository<PurchaseOrder> ,IPurchaseOrderRepository
    {
        public PurchaseOrderRepository(ErpContext context) : base(context)
        {
            
        }
    }
}
