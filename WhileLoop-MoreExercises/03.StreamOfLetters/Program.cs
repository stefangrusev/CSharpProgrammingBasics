using System;
using System.Collections.Generic;

namespace _03.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new List<char>();
            var currentWord = new List<char>();

            string input = string.Empty;

            bool letterCIsExist = false;
            bool letterOIsExist = false;
            bool letterNIsExist = false;

            while ((input = Console.ReadLine()) != "End")
            {
                char currentChar = input[0];

                if ((currentChar >= 'a' && currentChar <= 'z') ||
                    (currentChar >= 'A' && currentChar <= 'Z'))
                {
                    if (currentChar == 'c' && !letterCIsExist)
                    {
                        letterCIsExist = true;
                    }

                    else if (currentChar == 'o' && !letterOIsExist)
                    {
                        letterOIsExist = true;
                    }

                    else if (currentChar == 'n' && !letterNIsExist)
                    {
                        letterNIsExist = true;
                    }
                    else
                    {
                        currentWord.Add(currentChar);
                    }

                    if (letterCIsExist && letterOIsExist && letterNIsExist)
                    {
                        letterCIsExist = false;
                        letterOIsExist = false;
                        letterNIsExist = false;

                        foreach (var @char in currentWord)
                        {
                            message.Add(@char);
                        }

                        message.Add(' ');
                        currentWord.Clear();
                    }
                }
            }

            foreach (var @char in message)
            {
                Console.Write(@char);
            }
        }
    }
}
