using System;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthsAverage = int.Parse(Console.ReadLine());

            //double ePower = 0;
            double waterSupply = 20;
            double internet = 15;
            double others = 0;

            double ePowerBill = 0;
            double waterSupplyBill = 0;
            double internetBill = 0;
            double othersBill = 0;

            for (int i = 1; i <= monthsAverage; i++)
            {
                double eBill = double.Parse(Console.ReadLine());

                others = (eBill + waterSupply + internet) * 1.2;
                ePowerBill += eBill;
                waterSupplyBill += waterSupply;
                internetBill += internet;
                othersBill += others;
            }

            double averageBills = (ePowerBill + waterSupplyBill + internetBill + othersBill) / monthsAverage;

            Console.WriteLine($"Electricity: {ePowerBill:f2} lv");
            Console.WriteLine($"Water: {waterSupplyBill:f2} lv");
            Console.WriteLine($"Internet: {internetBill:f2} lv");
            Console.WriteLine($"Other: {othersBill:f2} lv");
            Console.WriteLine($"Average: {averageBills:f2} lv");

        }
    }
}
