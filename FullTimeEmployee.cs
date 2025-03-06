using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapOOP
{
    internal class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour) : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary_135()
        {
            return 8 * PaymentPerHour;
        }

        public override string getName_135()
        {
            return Name;
        }
    }
}
