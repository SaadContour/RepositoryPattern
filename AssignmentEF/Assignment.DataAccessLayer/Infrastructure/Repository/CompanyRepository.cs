using Assignment.DataAccessLayer.Data;
using Assignment.DataAccessLayer.Infrastructure.IRepository;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.DataAccessLayer.Infrastructure.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(ErpContext context) : base(context)
        {
            
        }
    }
}
