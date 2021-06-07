using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Models
{
    [Table("Beverages")]
    public class Beverage : Product
    {
        public double Millimeter { get; set; }

        public bool IsCarbonated { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
