using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FctTestSubject
{
    public class Factory
    {
        public int FactoryId { get; set; }
        public string FactoryName { get; set; } = string.Empty;
        public int ProductInHour { get; set; }

        public Factory(int factoryId, string factoryName, int productInHour)
        {
            FactoryId = factoryId;
            FactoryName = factoryName;
            ProductInHour = productInHour;
        }

        public override string ToString()
        {
            return $"{FactoryName}: {ProductInHour}";
        }

        public string MakeProduct(Product product, Warehouse warehouse)
        {
            var sb = new StringBuilder();
            warehouse.NumberOfProducts += ProductInHour;
            for (int i = 0; i < ProductInHour; i++)
            {
                warehouse.Products.Enqueue(product);
            }
            sb.AppendLine($"Factory {FactoryId} made a {product.ProductName}, quantity: {ProductInHour}");

            //This "Hour"
            Thread.Sleep(200);

            return sb.ToString();
        }

    }
}
