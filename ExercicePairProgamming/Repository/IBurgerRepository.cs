using ExercicePairProgamming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationBurger.Repositories
{
    public interface IBurgerRepository
    {
        public IQueryable<Product> GetBurger();
        public void AddBurger(Burger burger);
        public void DeleteBurger(Burger burger);
    }
}