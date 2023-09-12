using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatec.eCommT2.Domain.Models
{
    public class Brand
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public List<Product> Products { get; set; }
    }
}
