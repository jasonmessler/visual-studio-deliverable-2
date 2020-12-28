using System;

namespace coin_flip_final
{
    class Program
    {
        static void Main(string[] args)
        {
            int headsCount = 0;
            int tailsCount = 0;
            int correctCount = 0;  // point 7
            int currentFlip = 1;
            
            Random randomNumbers = new Random();

            Console.Write("Heads or Tails? >> ");
            string headsOrTailsGuess = Console.ReadLine().ToLower(); //points 1 and 2

            Console.WriteLine("You answered " + headsOrTailsGuess); //checks until here


            Console.Write("How many times should I flip? >> ");
            string flipsAnswer = Console.ReadLine();
            int numberOfFlips = Convert.ToInt32(flipsAnswer); //point 3

            Console.WriteLine("You answered " + numberOfFlips); //checks until here

            while (currentFlip <= numberOfFlips) //point 4
            {
                int coinstatus = randomNumbers.Next(0, 2); //point 5
                currentFlip++;

                if (coinstatus == 0)     //point 6
                {
                    Console.WriteLine("heads");
                    headsCount++;
                    if (headsOrTailsGuess == "heads")
                    {
                        correctCount++; //point 7 
                    }
                }

                else
                {
                    Console.WriteLine("tails");
                    tailsCount++;
                    if (headsOrTailsGuess == "tails")
                    {
                        correctCount++;
                    }
                }

            }
            int correctPercentage = (int) ((double)correctCount/numberOfFlips *100);

            Console.WriteLine("Your guess " + headsOrTailsGuess + " came up " + correctCount + " time(s). That's " + correctPercentage + "%"); //points 8, 9, and 10 (10 doesn't work yet)
            Console.WriteLine();
            Console.WriteLine("press enter to close");
            Console.ReadLine();

        }
    }
}
