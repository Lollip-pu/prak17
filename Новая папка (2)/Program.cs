using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class Order
    {
        public int id;
        public decimal total;
        public int Id {  get; set; }
        public decimal Total {  get; set; }
        public Order() { }
        public Order(int Id, decimal Total)
        {
            Id = id;
            Total = total;
        }

      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Order { Id = 1001, Total = 1500.50m };
            var order2 = order1;
            order2.Total = 2000.00m;
            Console.WriteLine(order1.Total);

        }
    }
}
