using Data.DataAccess;
using Data.Repositories.Interfaces;
using Services.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class ProductRepository : Repository, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Product NewProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
