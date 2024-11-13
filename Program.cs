namespace Assignment_2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Bill bill = new Bill();
                TipCalculator tipCal = new TipCalculator();

                Console.WriteLine("Enter the bill total: ");
                tipCal.TotalBill = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Tip Options:");
                tipCal.TipCal();
            do { 
                Console.WriteLine("Enter one of the following tip options or enter custom tip: ");
                tipCal.TipPercent = Convert.ToDouble(Console.ReadLine());

                tipCal.TotalTip = tipCal.TotalBill * (tipCal.TipPercent / 100);
                tipCal.TotalBillWithTip = tipCal.TotalBill + tipCal.TotalTip;

                Console.WriteLine($"\tTip percent: {tipCal.TipPercent}% " +
                    $"\n\tTip Amount: ${Math.Round(tipCal.TotalTip, 2)}" +
                    $"\n\tTotal Amount: ${Math.Round(tipCal.TotalBillWithTip, 2)}");

                Console.WriteLine("Would you like to complete your purchase? (Y/N)"); //allowing user to complete purchase or change percentage to the desired
            } 
            
            while (Console.ReadLine().ToUpper() != "Y") ;

            Console.WriteLine("\t\t\t\t Payment complete.");
            Console.WriteLine("\t\t\t\t This is the end of the code.");

           
        }
    }
    public class Bill //base class
    {
        private double totalBill;
        private double tipPercent;
        private double totalTip;
        private double totalBillWithTip;
        public  double TotalBill {  get; set; }
        public double TipPercent { get; set; }
        public double TotalTip { get; set; }
        public double TotalBillWithTip { get; set; }

        public void Cal()
        { 
        }
    }
    public class TipCalculator : Bill //derived class 
    {
        public double PercentTip15 { get; set; }
        public double PercentTip18 { get; set; }
        public double PercentTip20 { get; set; }
       


        public void TipCal()
        {
            TotalTip = TotalBill * (TipPercent / 100);
            TotalBillWithTip = TotalBill + TotalTip;

            PercentTip15 = TotalBill * 15 / 100;
            Console.WriteLine($"\t15% Tip: ${Math.Round(PercentTip15,2)}");

            PercentTip18 = TotalBill * 18 / 100;
            Console.WriteLine($"\t18% Tip: ${Math.Round(PercentTip18,2)}");

            PercentTip20 = TotalBill * 20 / 100;
            Console.WriteLine($"\t20% Tip: ${Math.Round(PercentTip20,2)}");
            
        }
    }
    


}
