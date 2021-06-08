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
		public IQueryable<Burger> GetBurgers();

		public Burger CreateBurger(Burger burger);

		public Burger EditBurger(int id, Burger burger);

		public void DeleteBurger(int id);
	}
}