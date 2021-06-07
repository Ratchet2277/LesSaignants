using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Models
{
    public class Beverage : Product
    {
        public double Millimeter { get; set; }

        public bool IsCarbonated { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
