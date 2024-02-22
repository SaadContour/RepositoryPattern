using Assignment.DataAccessLayer.Data;
using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DataAccessLayer.Infrastructure.Repository
{
    public class DeliveryRepository : Repository<Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(ErpContext context) : base(context)
        {
             
        }
    }
}
