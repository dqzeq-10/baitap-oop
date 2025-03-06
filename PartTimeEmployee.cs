using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapOOP
{
    internal class PartTimeEmployee : Employee
    {
        private int workingHours;

        public PartTimeEmployee(string name, int paymentPerHour, int workingHours) : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        public override int calculateSalary()
        {
            return workingHours * PaymentPerHour;
        }

        public override string getName()
        {
            return Name;
        }
    }
}
