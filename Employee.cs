using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapOOP
{
    internal abstract class Employee : IEmployee
    {
        String name_135;
        int paymentPerHour_135;

        public Employee(string name, int paymentPerHour)
        {
            this.name_135 = name;
            this.paymentPerHour_135 = paymentPerHour;
        }

        public string Name{
            get => name_135;
            set => name_135 = value;
        }

        public int PaymentPerHour{ 
            get => paymentPerHour_135;
            set => paymentPerHour_135 = value; 
        }

        public abstract int calculateSalary_135();
        public abstract string getName_135();
    }
}
