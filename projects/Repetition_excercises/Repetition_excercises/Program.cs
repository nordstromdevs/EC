using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lotteryNumbers = Lottery.GenerateNumbers();

            foreach (var item in lotteryNumbers)
                Console.WriteLine(item);

            Console.ReadKey();
            Console.WriteLine("-----------------------------------");

            var entity = new ProductEntity(ProductStateEnum.InStock, "Kalaskulor", 42);
            Console.WriteLine(entity);

            var money = Convert.ToDecimal(12.34); // alt to suffixing with m
            var line = new Orderline(entity, 10, 12.34m);

            Console.WriteLine(line);
            Console.ReadKey();

            Console.WriteLine("-----------------------------------");

            var p1 = new ProductEntity(ProductStateEnum.InStock, "Kalaskulor", 42);
            var p2 = new ProductEntity(ProductStateEnum.NotForSale, "KalasPuppar", 43);
            var p3 = new ProductEntity(ProductStateEnum.OutOfStock, "Frosties", 44);
            var p4 = new ProductEntity(ProductStateEnum.InStock, "Surkål", 45);

            Order order = new Order("EC-Gruppen");
            order.AddOrderLine(new Orderline(p1, 10, 50)); //(Product, Quantity, Price)
            order.AddOrderLine(new Orderline(p2, 10, 2));
            order.AddOrderLine(new Orderline(p3, 1000, 2));
            order.AddOrderLine(new Orderline(p4, 1, 9.50m));

            Console.WriteLine(order);
            Console.ReadKey();
        }
    }
}
