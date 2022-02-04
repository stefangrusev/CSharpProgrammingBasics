using System;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int doctors = 7;
            int patients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= days; i++)
            {
                int dailyPatients = int.Parse(Console.ReadLine());
                int dailyUntreatedPatients = 0;

                if (i % 3 == 0)
                {
                    doctors += (patients < untreatedPatients) ? 1 : 0;
                }

                if (dailyPatients > doctors)
                {
                    untreatedPatients += (dailyPatients - doctors);
                    dailyUntreatedPatients += (dailyPatients - doctors);
                    dailyPatients -= dailyUntreatedPatients;
                }

                patients += dailyPatients;
            }

            Console.WriteLine($"Treated patients: {patients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");

        }
    }
}