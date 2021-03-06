using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Models
{
    [Table("Desserts")]
    public class Dessert : Product
    {
        public int Millimeter { get; set; }

        public bool IsFrozen { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
