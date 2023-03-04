using System;

namespace Exam_26_02_2023
{
    internal class Program
    {
        static void Main(string[] args)
        
       {
            ///Zadacha 01.Moon
            //double avgSpeed = double.Parse(Console.ReadLine());
            //double litersPer100km = double.Parse(Console.ReadLine());

            //int distanceOneWay = 384400;
            //int distanceBothWays = distanceOneWay * 2;
            //double timeToAndBack = Math.Ceiling(distanceBothWays / avgSpeed) + 3;

            //double fuel = (distanceBothWays * litersPer100km) / 100;
            //Console.WriteLine($"{timeToAndBack}");
            //Console.WriteLine($"{fuel}");

            ////Zadacha 02. AND Processors
            //int numProcessorsRequired = int.Parse(Console.ReadLine());
            //int numPersonel = int.Parse(Console.ReadLine());
            //int numWorkDays = int.Parse(Console.ReadLine());

            //int timeForOneProccessor = 3;
            //double priceForOneProcessor = 110.10;
            //int timeForWork = 8;

            //double workLimit = numPersonel * numWorkDays * 8;
            //double workProccess = Math.Floor(workLimit / timeForOneProccessor);
            //double conditionsPlus = workProccess - numProcessorsRequired;
            //double condidionsMinus = numProcessorsRequired - workProccess;

            //if (workProccess >= numProcessorsRequired)
            //{
            //    Console.WriteLine($"Profit: -> {conditionsPlus*priceForOneProcessor:f2} BGN");
            //}
            //else
            //{
            //    Console.WriteLine($"Losses: -> {condidionsMinus*priceForOneProcessor:f2} BGN");

            //}

            ////Zadacha 03. Football Souvenirs
            //            string team = Console.ReadLine(); 
            //            string souvenirs = Console.ReadLine();
            //            int numSouvenirsBought = int.Parse(Console.ReadLine());

            //            double itemPrice = 0;

            //            switch (team)
            //            {
            //                case "Argentina":
            //                    switch (souvenirs)
            //                    {
            //                        case "flags":
            //                            itemPrice = 3.25; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break;
            //                        case "caps":
            //                            itemPrice = 7.20; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break;
            //                        case "posters":
            //                            itemPrice = 5.10; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break;
            //                        case "stickers":
            //                            itemPrice = 1.25; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break;
            //                        default:
            //                            Console.WriteLine("Invalid stock!");
            //                            break;
            //                    }
            //                    break;
            //                case "Brazil":
            //                    switch (souvenirs)
            //                    {
            //                        case "flags":
            //                            itemPrice = 4.20; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break;
            //                        case "caps":
            //                            itemPrice = 8.50; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break; 
            //                        case "posters":
            //                            itemPrice = 5.35; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break;
            //                        case "stickers":
            //                            itemPrice = 1.20; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break;
            //                        default:
            //                            Console.WriteLine("Invalid stock!");
            //                            break;
            //                    }
            //                    break;
            //                case "Croatia":
            //                    switch (souvenirs)
            //                    {
            //                        case "flags":
            //                            itemPrice = 2.75; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break;
            //                        case "caps":
            //                            itemPrice = 6.90; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break;
            //                        case "posters":
            //                            itemPrice = 4.95; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break;
            //                        case "stickers":
            //                            itemPrice = 1.10; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");
            //                            break;
            //                        default:
            //                            Console.WriteLine("Invalid stock!");
            //                            break;
            //                    }
            //                    break;
            //                case "Denmark":
            //                    switch (souvenirs)
            //                    {
            //                        case "flags":
            //                            itemPrice = 3.10; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");

            //                            break;
            //                        case "caps":
            //                            itemPrice = 6.50; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");

            //                            break;
            //                        case "posters":
            //                            itemPrice = 4.80; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");

            //                            break;
            //                        case "stickers":
            //                            itemPrice = 0.90; Console.WriteLine($"Pepi bought {numSouvenirsBought} {souvenirs} of {team} for {itemPrice * numSouvenirsBought:f2} lv.");

            //                            break;
            //                        default:
            //                            Console.WriteLine("Invalid stock!");
            //                            break;
            //                    }
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid country!");
            //                    break;
            //            }

            ////Zadacha 04. Gifts from Santa
            //int N = int.Parse(Console.ReadLine());
            //int M = int.Parse(Console.ReadLine());
            //int S = int.Parse(Console.ReadLine());

            //for (int i = M; i >= N; i--)
            //{
                
            //    if (i%3==0&&i%2==0)
            //    {
            //        if(i==S) { break; }
            //        Console.Write(i + " ");
            //    }
                
            //}


            ////Zadacha 05. Puppy Care
            //int dogFoodKG = int.Parse(Console.ReadLine());
            //int dogFoodGrams = dogFoodKG * 1000;
            //double remainingFood = 0;
            //string input;
            //while ((input=Console.ReadLine())!="Adopted" ){ 
            //double gramsPerDog = double.Parse(input);
            //   remainingFood+=gramsPerDog;
            //    continue;
            //}
            //if (dogFoodGrams >= remainingFood)
            //{
            //    Console.WriteLine($"Food is enough! Leftovers: {dogFoodGrams - remainingFood} grams.");
            //}
            //else
            //{
            //    Console.WriteLine($"Food is not enough. You need {remainingFood - dogFoodGrams} grams more.");

            //}

            ////Zadacha 06. Gold Mine
            //int numLocations = int.Parse(Console.ReadLine());

            //double goldPerDay = 0;
            //double avgGold = 0;
            //int numOfDays = 0;
            
            //double finalPrice = 0;

            //for (int i = 1; i <= numLocations; i++)
            //{
            //        avgGold = int.Parse(Console.ReadLine());
            //    numOfDays = int.Parse(Console.ReadLine());
            //    double dailyGold = 0;
            //    for (int h = 1; h <= numOfDays; h++)
            //    {
                    
            //        goldPerDay = double.Parse(Console.ReadLine());
            //        dailyGold = goldPerDay + dailyGold;
                    
            //    }
            //    finalPrice = dailyGold / numOfDays;
            //    if (avgGold< dailyGold / numOfDays) { Console.WriteLine($"Good job! Average gold per day: {finalPrice:f2}."); }
            //    else { Console.WriteLine($"You need {avgGold - finalPrice:f2} gold."); }
            //    dailyGold *=0;
            //}

        }
        
    }
}