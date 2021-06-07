using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Models
{
    public class Burger : Product
    {
        public int Weight { get; set; }

        public int BeefWeight { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
