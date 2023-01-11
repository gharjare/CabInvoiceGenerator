namespace CabInvoiceGenerator1
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" ");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");
        }
    }
}