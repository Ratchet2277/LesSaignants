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
		private readonly SaignantsContext context;
		public Burger CreateBurger(Burger burger)
        {
			context.Burgers.Add(burger);
			context.SaveChanges();
			return burger;
		}

        public void DeleteBurger(int id)
        {
			var beverage = context.Beverages.Find(id);
			context.Beverages.Remove(beverage);
		}

        public Burger EditBurger(int id, Burger editburger)
        {
			var burger = context.Burgers.Find(id);
			burger.Name = editburger.Name;
			burger.Price = editburger.Price;
			burger.Description = editburger.Description;
			burger.Weight = editburger.Weight;
			burger.BeefWeight = editburger.BeefWeight;
			burger.SaveChanges();

			return context.Burgers.Find(id);
		}

        public IQueryable<Burger> GetBurgers()
        {
			return context.Burgers;
		}
    }
}