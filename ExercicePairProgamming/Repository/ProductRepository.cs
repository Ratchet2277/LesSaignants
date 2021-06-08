using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicePairProgamming.Dal;
using ExercicePairProgamming.Models;

namespace WebApplicationBurger.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private SaignantsContext context;

        public ProductRepository(SaignantsContext context)
        {
            this.context = context;
        }

        public IQueryable<Product> GetProducts()
        {
            return context.Burgers;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}