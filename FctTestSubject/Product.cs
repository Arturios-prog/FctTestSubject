using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FctTestSubject
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double Weight { get; set; }
        public PackageType PackageType { get; set; }

        public override string ToString()
        {
            var productData = $"{ProductName}: \n Weight: \t {Weight}\n PackageType: \t{Enum.GetName(PackageType)}";
            return productData;
        }
    }
}
