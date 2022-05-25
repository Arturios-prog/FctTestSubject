using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FctTestSubject
{
    public partial class Form1 : Form
    {
        private static List<Factory> _factories = new List<Factory>();
        private static List<Product> _products = new List<Product>();
        private static ConcurrentBag<Truck> _trucks = new ConcurrentBag<Truck>();
        private static Warehouse _warehouse = new Warehouse();
        private static double _sumOfAllProductions = 0;

        Array packageValues = Enum.GetValues(typeof(PackageType));
        Array capacityValues = Enum.GetValues(typeof(CapacityType));

        delegate void MyAppendTextBox(string message);
        MyAppendTextBox invoker;

        CancellationTokenSource cts1 = new CancellationTokenSource();
        CancellationTokenSource cts2 = new CancellationTokenSource();

        public Form1()
        {
            InitializeComponent();
            invoker = textBox1.AppendText;
        }

        private void LoopMakingProducts(int i)
        {
            while (true)
            {
                if (cts2.Token.IsCancellationRequested) return;
                textBox1.Invoke(invoker, _factories[i].MakeProduct(_products[i], _warehouse));
            }
        }

        private void LoopUnloadPackages(Truck truck)
        {
            while (true)
            {
                if (cts1.Token.IsCancellationRequested || cts2.Token.IsCancellationRequested) return;

                truck.UnloadPackages(_warehouse, Statistics.Products);
            }
        }

        private void StartProducing()
        {
            for (int i = 0; i < _factories.Count; i++)
            {
                if (cts2.Token.IsCancellationRequested) return;

                Task task = new Task(i => LoopMakingProducts((int)i), i);
                task.Start();
            }

        }
        private async void StartWatchingWarehouse()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    if (cts2.Token.IsCancellationRequested) return;

                    if (_warehouse.NumberOfProducts / _warehouse.MaxNumberOfProducts * 100d >= 95d)
                    {

                        //Crutch
                        if (cts1.IsCancellationRequested)
                        {
                            cts1 = new CancellationTokenSource();
                            Statistics.NumberOfIterations++;

                            foreach (var truck in _trucks)
                            {
                                Action action = new Action(() => LoopUnloadPackages(truck));
                                Task task = new Task(action);
                                task.Start();
                            }
                        }

                        
                    }
                    if (_warehouse.NumberOfProducts <= _warehouse.MaxNumberOfProducts / 10)
                    {
                        cts1.Cancel();
                    }

                }
            });
        }
        private async void ProgressBarUpdate()
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    if (cts2.Token.IsCancellationRequested) return;
                    labelWarehouseNum.Invoke((MethodInvoker)(() => labelWarehouseNum.Text = $"{_warehouse.NumberOfProducts}"));
                    warehouseProgBar.Invoke((MethodInvoker)(() =>
                    warehouseProgBar.Value = (int)_warehouse.NumberOfProducts));
                }
            });
        }

        public static class Statistics
        {
            public static int NumberOfIterations { get; set; } = 0;
            public static ConcurrentBag<Product> Products { get; set; } = new ConcurrentBag<Product>();

            public static string ComputeStatistics()
            {
                var sb = new StringBuilder();
                for (int i = 0; i < _products.Count; i++)
                {
                    if (NumberOfIterations == 0) {
                        sb.Append("Trucks haven't unloaded any packages");
                        return sb.ToString();
                    }

                    double averageAmount = (double)(Products.Where(p=> p.ProductId == (i+1)).Count()) / NumberOfIterations;

                    sb.AppendLine($"For {_products[i].ProductName} with weight {_products[i].Weight} and Package {_products[i].PackageType}: \n {averageAmount} was unloaded in average");
                }
                return sb.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //random value for packageTypes
            Random random = new Random();
            //number of values in packageTypes

            //Disabling all the input...
            factoryNumDrop.Enabled = false;
            productHourNumDrop.Enabled = false;
            mNumDrop.Enabled = false;
            button1.Enabled = false;

            cts1 = new CancellationTokenSource();
            cts2 = new CancellationTokenSource();

            //Creating factories and products
            for (int i = 0; i < factoryNumDrop.Value; i++)
            {
                _factories.Add(new Factory(i + 1,
                    $"Factory {i + 1}",
                    (int)Math.Round((double)productHourNumDrop.Value * (((double)i / 10) + 1), 0, MidpointRounding.ToZero)));

                _products.Add(new Product()
                {
                    ProductId = i+1,
                    ProductName = $"Product from Factory {i + 1}",
                    Weight = Math.Round(random.Next(50) + random.NextDouble() * random.Next(10), 2),

                    //Not sure how to get rid of this warning
                    PackageType = (PackageType)packageValues.GetValue(random.Next(packageValues.Length))
                });

                _sumOfAllProductions += Math.Round((double)productHourNumDrop.Value * (((double)i / 10) + 1), 0, MidpointRounding.ToZero);
            }

            _warehouse = new Warehouse
            {
                NumberOfProducts = 0,
                MaxNumberOfProducts = _sumOfAllProductions * (double)mNumDrop.Value
            };

            /*
             * This is probably a dumb way to do this but im finding out the minimum of trucks
             * which are needed to unload the warehouse at full capacity by simply summing all the
             * truck's capacities and finding the ratio between them and a warehouse capacity
             */

            var sumOfAllTruckCapacities = capacityValues.Cast<int>().Sum();
            var setOfTrucksToAdd = Math.Round(_warehouse.MaxNumberOfProducts / sumOfAllTruckCapacities, 0, MidpointRounding.AwayFromZero);

            for (int i = 1; i < setOfTrucksToAdd; i++)
            {

                foreach (CapacityType type in capacityValues)
                {
                    Truck truck = new Truck(i + Array.IndexOf(capacityValues, type), type);
                    
                    _trucks.Add(truck);
                }

            }

            Debug.WriteLine($"MaxNumOFProd: {_warehouse.MaxNumberOfProducts}");

            Debug.Write($"Nubmer of trucks: {_trucks.Count()}");

            warehouseProgBar.Maximum = (int)_warehouse.MaxNumberOfProducts;
            StartWatchingWarehouse();
            ProgressBarUpdate();
            StartProducing();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cts2.Cancel();
            labelWarehouseNum.Text = "0";

            statsTextBox.AppendText(Statistics.ComputeStatistics());
            Statistics.NumberOfIterations = 0;
            Statistics.Products.Clear();
            _warehouse = new Warehouse();
            _factories.Clear();
            _products.Clear();
            _trucks.Clear();
        }
    }
}