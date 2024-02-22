using Assignment.DataAccessLayer.Data;
using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.DataAccessLayer.Infrastructure.Repository
{
    public class PurchaseOrderDeliveryItemRepository : Repository<PurchaseOrderDeliveryItem> , IPurchaseOrderDeliveryItemRepository
    { 
        public PurchaseOrderDeliveryItemRepository(ErpContext context) : base(context)
        {
        }
    }
}
