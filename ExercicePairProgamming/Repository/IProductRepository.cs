using ExercicePairProgamming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationBurger.Repositories
{
    public interface IProductRepository
    {
        public IQueryable<Product> GetProducts();
        public void AddProduct(Product product);
        public void DeleteProduct(Product product);
    }
}