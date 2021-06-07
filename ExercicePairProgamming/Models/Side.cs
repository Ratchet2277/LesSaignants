using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Models
{
    public class Side : Product
    {
        public int Weight { get; set; }

        public int SaltWeight { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
