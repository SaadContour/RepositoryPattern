using Assignment.DataAccessLayer.Data;
using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DataAccessLayer.Infrastructure.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ErpContext context) : base(context)
        {

        }
    }
}
