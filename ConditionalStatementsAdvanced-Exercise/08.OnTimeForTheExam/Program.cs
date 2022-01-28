using System;

namespace OnTimeForExam
{
    class OnTimeForExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int studentHour = int.Parse(Console.ReadLine());
            int studentMinute = int.Parse(Console.ReadLine());

            int examTimeMins = examHour * 60 + examMinute;
            int studentTimeMins = studentHour * 60 + studentMinute;

            int diffInTimes = Math.Abs(examTimeMins - studentTimeMins);

            if (examTimeMins == studentTimeMins || (examTimeMins > studentTimeMins && diffInTimes <= 30))
            {
                if (diffInTimes != 0)
                {
                    Console.WriteLine("On Time");
                    Console.WriteLine($"{diffInTimes} minutes before the start");
                }
                else
                {
                    Console.WriteLine("On Time");
                }
            }
            
            else if (examTimeMins > studentTimeMins && diffInTimes > 30)
            {

                if (diffInTimes < 60) 
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diffInTimes} minutes before the start");
                }
                else
                {
                    int minutes = diffInTimes % 60;                 
                    diffInTimes /= 60;                              

                    Console.WriteLine("Early");
                    Console.WriteLine($"{diffInTimes}:{minutes:d2} hours before the start");
                }
            }
            
            else
            {
                if (diffInTimes < 60) 
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diffInTimes} minutes after the start");
                }
                else
                {
                    int minutes = diffInTimes % 60;                 
                    diffInTimes /= 60;                              

                    Console.WriteLine("Late");
                    Console.WriteLine($"{diffInTimes}:{minutes:d2} hours after the start");
                }
            }
        }
    }
}