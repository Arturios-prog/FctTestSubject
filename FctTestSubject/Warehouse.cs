using Microsoft.VisualStudio.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FctTestSubject
{
    public class Warehouse
    {
        public AsyncQueue<Product> Products { get; set; } = new AsyncQueue<Product>();
        public double NumberOfProducts { get; set; }
        public double MaxNumberOfProducts { get; set; }
        
    }
}
