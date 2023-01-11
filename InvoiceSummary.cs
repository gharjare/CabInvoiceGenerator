using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator1
{
    public class InvoiceSummary
    {
        private int numberOfRides;
        private double totalFare;
        private double averageFare;
        private int length;

        public InvoiceSummary(int length, double totalfare)
        {
            this.length = length;
            totalFare = totalfare;
        }

        public InvoiceSummary(int numberOfRides, double totalFare, double averageFare)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            this.averageFare = this.totalFare / this.numberOfRides;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;

            InvoiceSummary inputObject = (InvoiceSummary)obj;
            return this.numberOfRides == inputObject.numberOfRides && this.totalFare == inputObject.totalFare && this.averageFare == inputObject.averageFare;
        }

        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode();
        }
    }
}
