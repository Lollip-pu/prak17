using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public struct Weather
    {
        public string City;
        public double? Temperature;
       
        public override string ToString() {
            string temperatureText = Temperature.HasValue ? $"{Temperature}°C" : "Нет данных";
            return $"{City}: {temperatureText}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var w1 = new Weather { City = "Москва", Temperature = 22.5 };
            var w2 = new Weather { City = "Сочи", Temperature = null };
            Console.WriteLine(w1); 
            Console.WriteLine(w2); 
            Console.WriteLine(w2.Temperature ?? -999); 

        }
    }
}
