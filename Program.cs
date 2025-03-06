using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trần Đình Quý - 22115053122135");
            IEmployee employee1_135 = new PartTimeEmployee("Trung", 45000, 7);
            Console.WriteLine("Name: " + employee1_135.getName_135());
            Console.WriteLine("Salary per day: " + employee1_135.calculateSalary_135());

            IEmployee employee2_135 = new FullTimeEmployee("Linh", 65000);
            Console.WriteLine("Name: " + employee2_135.getName_135());
            Console.WriteLine("Salary per day: " + employee2_135.calculateSalary_135());
            Console.ReadKey();
        }
    }
}
