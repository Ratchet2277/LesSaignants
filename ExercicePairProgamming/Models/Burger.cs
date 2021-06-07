using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Models
{
    [Table("Burgers")]
    public class Burger : Product
    {
        public int Weight { get; set; }

        public int BeefWeight { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
