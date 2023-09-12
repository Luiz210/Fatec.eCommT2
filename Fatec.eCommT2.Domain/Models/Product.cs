using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatec.eCommT2.Domain.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public Guid BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public float Size { get; set; }
        public int IsActive { get; set; }
    }
}
