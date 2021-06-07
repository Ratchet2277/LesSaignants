using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public int Stockpiled { get; set; }
    }
}
