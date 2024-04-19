namespace Functions {
    internal class Program {
        static void Main(string[] args) {
            SalesTax();
        }
        static void SalesTax() {
            //VARS
            double stateTax = 0;
            double countyTax = 0;
            double totalTax = 0;
            double total = 0;
            double purchaseAmount = 0;

            //INPUT
            Console.WriteLine("Enter Purchase Amount");
            purchaseAmount = double.Parse(Console.ReadLine());

            //PROCESS
            stateTax = CalcState(purchaseAmount);
            countyTax = CalcCounty(purchaseAmount);
            totalTax = CalcTax(purchaseAmount);
            total = CalcTotal(purchaseAmount);
            //OUTPUT
        }
        static double CalcState(double price) {
            return price * 0.04;
        }
        static double CalcCounty(double price) {
            return price * 0.02;
        }

        static double CalcTax(double price) {
            return CalcState(price) + CalcCounty(price);
        }

        static double CalcTotal(double price) {
            return price + CalcTax(price);
        }
    }
}