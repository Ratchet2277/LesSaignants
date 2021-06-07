using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Models
{
    public class Menu : Product
    {
        public virtual Beverage Beverage { get; set; }

        public virtual Side Side { get; set; }

        public virtual Dessert Dessert { get; set; }

        public virtual Burger Burger { get; set; }
    }
}
