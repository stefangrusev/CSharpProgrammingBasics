using System;

namespace _02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int playingRate = 30000;
            int offPlayingTime = daysOff * 127;
            int workPlayingTime = (365 - daysOff) * 63;
            int playingTime = offPlayingTime + workPlayingTime;
            int hoursLeft = (playingRate - playingTime) / 60;
            int minutesLeft = (playingRate - playingTime) % 60;
            int timeForGames = (playingTime - playingRate) / 60;
            int minutesForGames = (playingTime - playingRate) % 60;
            Console.WriteLine(playingRate >= playingTime ? $"Tom sleeps well{Environment.NewLine}{hoursLeft} hours and {minutesLeft} minutes less for play"
                                                      : $"Tom will run away{Environment.NewLine}{timeForGames} hours and {minutesForGames} minutes more for play");
        }
    }
}
