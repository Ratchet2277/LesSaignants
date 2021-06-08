using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicePairProgamming.Dal;
using ExercicePairProgamming.Models;

namespace WebApplicationBurger.Repositories
{
    public class BurgerRepository : IBurgerRepository
    {
        private SaignantsContext context;

        public BurgerRepository(SaignantsContext context)
        {
            this.context = context;
        }

        public IQueryable<Burger> GetBurgers()
        {
            return context.Burgers;
        }

        public void AddBurger(Burger burger)
        {
            throw new NotImplementedException();
        }

        public void DeleteBurger(Burger burger)
        {
            throw new NotImplementedException();
        }

        IQueryable<Product> IBurgerRepository.GetBurger()
        {
            throw new NotImplementedException();
        }
    }
}