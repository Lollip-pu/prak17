using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public enum EmploymentStatus { Active, OnLeave, Terminated }
    public class Employee
    {
        public string Name;
        public DateTime? HireDate;
        public  EmploymentStatus Status;
        public int GetYearsWorked()
        {
            if (!HireDate.HasValue)
                return -1;

            DateTime currentDate = DateTime.Now;
            int years = currentDate.Year - HireDate.Value.Year;
            if (currentDate < HireDate.Value.AddYears(years))
            {
                years--;
            }

            return years;
        }
        public override string ToString()
        {
            string yearsWorkedText = HireDate.HasValue ? $"{GetYearsWorked()} лет" : "не указан";
            return $"{Name}, статус: {Status}, стаж: {yearsWorkedText}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee
            {
                Name = "Пётр",
                HireDate = new DateTime(2020, 3, 15),
                Status = EmploymentStatus.Active
            };
            Console.WriteLine(emp.GetYearsWorked()); 
            emp.HireDate = null;
            Console.WriteLine(emp.GetYearsWorked()); 
            Console.WriteLine(emp); 

        }
    }
}
