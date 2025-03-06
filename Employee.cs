using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapOOP
{
    internal abstract class Employee : IEmployee
    {
        String name;
        int paymentPerHour;

        public Employee(string name, int paymentPerHour)
        {
            this.Name = name;
            this.PaymentPerHour = paymentPerHour;
        }

        public string Name{
            get => name;
            set => name = value;
        }

        public int PaymentPerHour{ 
            get => paymentPerHour;
            set => paymentPerHour = value; 
        }

        public abstract int calculateSalary();
        public abstract string getName();
    }
}
