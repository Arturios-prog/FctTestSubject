using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FctTestSubject
{
    public class Truck
    {
        public int TruckId { get; set; }
        public int MaxCapacity { get; set; }
        public CapacityType Capacity { get; set; }

        public Truck(int id, CapacityType capacity)
        {
            TruckId = id;
            Capacity = capacity;
            MaxCapacity = (int)Enum.Parse(typeof(CapacityType), Enum.GetName(capacity));

        }
        public void UnloadPackages(Warehouse warehouse)
        {
            for (int i = 0; i < MaxCapacity; i++)
            {
                if (!warehouse.Products.IsEmpty && warehouse.NumberOfProducts > warehouse.MaxNumberOfProducts / 10)
                {

                    warehouse.Products.DequeueAsync();
                    warehouse.NumberOfProducts--;
                }

                else break;

            }
            //"Time" of getting back to warehouse
            Thread.Sleep(200);

        }

        public void UnloadPackages(Warehouse warehouse, ConcurrentBag<Product> products)
        {
            for (int i = 0; i < MaxCapacity; i++)
            {
                if (!warehouse.Products.IsEmpty && warehouse.NumberOfProducts > warehouse.MaxNumberOfProducts / 10)
                {
                    products.Add(warehouse.Products.Peek());
                    warehouse.Products.DequeueAsync();
                    warehouse.NumberOfProducts--;
                }

                else break;

            }
            //"Time" of getting back to warehouse
            Thread.Sleep(200);

        }
    }
}
