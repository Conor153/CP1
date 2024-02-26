// See https://aka.ms/new-console-template for more information
using LuciansLusciousLasagna;

Console.WriteLine("Hello, World!");


Lasagna lasagna = new Lasagna();

int timeLeft = lasagna.RemainingMinutesInOven(30);

int prepTime = lasagna.PreparationTimeInMinutes(5);



Console.WriteLine(prepTime);



Console.WriteLine(timeLeft);
