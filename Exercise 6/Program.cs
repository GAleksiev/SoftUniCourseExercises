using System.Text.Unicode;

namespace Exercise_5
{
        internal class Program
        {
        static void Main(string[] args)
        {
            //        using System;
            //                                                                namespace HelloSoftuni
            //{
            //    internal class Program
            //    {
            //        static void Main(string[] args)
            //        {

            //            Write Code Here


            //                                                                            }
            //    }
            //}
            ////Zadacha 01. Cinema
            //    string projectionClass = Console.ReadLine();
            //    int rows = int.Parse(Console.ReadLine());
            //    int columns = int.Parse(Console.ReadLine());
            //    if (projectionClass == "Premiere"){
            //        Console.WriteLine($"{rows*columns*12.00:f2} leva");
            //    }
            //    else if (projectionClass=="Normal"){
            //        Console.WriteLine($"{rows * columns * 7.50:f2} leva");
            //    }
            //    else{
            //        Console.WriteLine($"{rows * columns * 5:f2} leva");
            //    }


            ////Zadacha 02. Summer Outfit
            //int degrees = int.Parse(Console.ReadLine());
            //    string timeOfDay = Console.ReadLine();
            //    string Outfit ="";
            //    string Shoes = "";
            //    if (degrees >= 10 && degrees <= 18)
            //    {
            //        switch (timeOfDay)
            //        {
            //            case "Morning":
            //                Outfit = "Sweatshirt"; Shoes = "Sneakers";
            //                break;
            //            case "Afternoon":
            //                Outfit = "Shirt"; Shoes = "Moccasins";
            //                break;
            //            default:
            //                Outfit = "Shirt"; Shoes = "Moccasins";
            //                break;
            //        }
            //    }
            //    else if (degrees > 18 && degrees <= 24)
            //    {
            //        switch (timeOfDay)
            //        {
            //            case "Morning":
            //                Outfit = "Shirt"; Shoes = "Moccasins";
            //                break;
            //            case "Afternoon":
            //                Outfit = "T-Shirt"; Shoes = "Sandals";
            //                break;
            //            default:
            //                Outfit = "Shirt"; Shoes = "Moccasins";
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        switch (timeOfDay)
            //        {
            //            case "Morning":
            //                Outfit = "T-Shirt"; Shoes = "Sandals";
            //                break;
            //            case "Afternoon":
            //                Outfit = "Swim Suit"; Shoes = "Barefoot";
            //                break;
            //            default:
            //                Outfit = "Shirt"; Shoes = "Moccasins";
            //                break;
            //        }
            //    }
            //        Console.Write($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");

            ////Zadacha 03. New House ---------------------------------------------------------- Задачата, на която имах най-много затруднения.
            //        string flower = Console.ReadLine();
            //        int numFlowers = int.Parse(Console.ReadLine());
            //        int budget = int.Parse(Console.ReadLine());

            //        double flowerPrice=0;
            //        double discount=0;
            //        double priceFull = 1;
            //        double priceDiscount = 1;
            //        switch (flower)
            //        {
            //            case "Roses":
            //                flowerPrice = 5; discount = 0.1; if (numFlowers > 80) {priceDiscount = (numFlowers * flowerPrice) - ((numFlowers * flowerPrice) * discount); } else { priceFull = numFlowers * flowerPrice; }
            //                break;
            //            case "Dahlias":
            //                flowerPrice = 3.80; discount = 0.15; if (numFlowers > 90) { priceDiscount = (numFlowers * flowerPrice) - ((numFlowers * flowerPrice) * discount); } else { priceFull = numFlowers * flowerPrice; }
            //                break;
            //            case "Tulips":
            //                flowerPrice = 2.80; discount = 0.15; if (numFlowers > 80) { priceDiscount = (numFlowers * flowerPrice) - ((numFlowers * flowerPrice) * discount); } else { priceFull = numFlowers * flowerPrice; }
            //                break;
            //            case "Narcissus":
            //                flowerPrice = 3; discount = 0.15; if (numFlowers < 120) { priceDiscount = (numFlowers * flowerPrice) + ((numFlowers * flowerPrice) * discount); } else { priceFull = numFlowers * flowerPrice; }
            //                break;
            //            case "Gladiolus":
            //                flowerPrice = 2.50; discount = 0.2; if (numFlowers < 80) { priceDiscount = (numFlowers * flowerPrice) + ((numFlowers * flowerPrice) * discount); } else { priceFull = numFlowers * flowerPrice; }
            //                break;
            //            default:
            //                break;
            //        }
            //        if (budget>= numFlowers * flowerPrice&&budget>=priceFull&&budget>=priceDiscount) {
            //            Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flower} and {(budget - priceFull* priceDiscount):f2} leva left.");
            //        }
            //        else{
            //            Console.WriteLine($"Not enough money, you need {(priceFull  * priceDiscount - budget):f2} leva more.");
            //        }


            //Zadacha 04. Fishing Boat
            //int budget = int.Parse(Console.ReadLine());
            //        string season = Console.ReadLine();
            //        int numFishermen = int.Parse(Console.ReadLine());

            //        double rentSeason = 0;
            //        double priceDiscount = 0;
            //        switch (season)
            //        {
            //            case "Winter":
            //                rentSeason = 2600; 
            //                if (numFishermen <= 6){
            //                    priceDiscount = rentSeason - (rentSeason * 0.1); 
            //                }
            //                else if (numFishermen >=7 && numFishermen<=11){
            //                    priceDiscount = rentSeason - (rentSeason * 0.15);
            //                }
            //                else{
            //                    priceDiscount = rentSeason - (rentSeason * 0.25);
            //                }
            //                break;
            //            case "Spring": rentSeason = 3000; 
            //                if (numFishermen <= 6){
            //                    priceDiscount = rentSeason - (rentSeason * 0.1);
            //                }
            //                else if (numFishermen >= 7 && numFishermen <= 11){
            //                    priceDiscount = rentSeason - (rentSeason * 0.15);
            //                }
            //                else{
            //                    priceDiscount = rentSeason - (rentSeason * 0.25);
            //                }
            //                break;
            //            case "Summer": rentSeason = 4200;
            //                if (numFishermen <= 6){
            //                    priceDiscount = rentSeason - (rentSeason * 0.1);
            //                }
            //                else if (numFishermen >= 7 && numFishermen <= 11){
            //                    priceDiscount = rentSeason - (rentSeason * 0.15);
            //                }
            //                else{
            //                    priceDiscount = rentSeason - (rentSeason * 0.25);
            //                }
            //                break;
            //            case "Autumn": rentSeason = 4200;
            //                if (numFishermen <= 6){
            //                    priceDiscount = rentSeason - (rentSeason * 0.1);
            //                }
            //                else if (numFishermen >= 7 && numFishermen <= 11){
            //                    priceDiscount = rentSeason - (rentSeason * 0.15);
            //                }
            //                else{
            //                    priceDiscount = rentSeason - (rentSeason * 0.25);
            //                }
            //                break;
            //                default: break;
            //        }
            //        if (numFishermen % 2 == 0 && season != "Autumn")
            //        {
            //            priceDiscount = priceDiscount - priceDiscount * 0.05;
            //        }
            //        else
            //        {
            //            priceDiscount = priceDiscount;
            //        }
            //        if (budget>=priceDiscount)
            //        {
            //            Console.WriteLine($"Yes! You have {budget-priceDiscount:f2} leva left.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Not enough money! You need {priceDiscount-budget:f2} leva.");
            //        }

            ////Zadacha 05. Journey
            //int budget = int.Parse(Console.ReadLine());
            //string season = Console.ReadLine();

            //string location ="";
            //string placeToStay ="";
            //double priceDiscount = 0;

            //if (budget <= 100 ){
            //    location = "Somewhere in Bulgaria";
            //    if (season=="summer")
            //    {
            //        priceDiscount = budget * 0.3;
            //        placeToStay = "Camp";
            //    }
            //    else
            //    {
            //        priceDiscount = budget * 0.7;
            //        placeToStay = "Hotel";
            //    }
            //}
            //else if (budget<=1000)
            //{
            //    location = "Somewhere in Balkans";
            //    if (season == "summer")
            //    {
            //        priceDiscount = budget * 0.4;
            //        placeToStay = "Camp";
            //    }
            //    else
            //    {
            //        priceDiscount = budget * 0.8;
            //        placeToStay = "Hotel";
            //    }
            //}
            //else {
            //    location = "Somewhere in Europe";
            //     priceDiscount = budget * 0.9;
            //    placeToStay = "Hotel";
            //}

            //Console.WriteLine(location);
            //Console.WriteLine($"{placeToStay} - {priceDiscount:f2}");

            //Zadacha 06. Operations Between Numbers
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            double result = 0;

            if (symbol == "+") {
                result = N1+N2;
                if (result % 2 == 0) { Console.Write($"{N1} + {N2} = {result} - even"); }
                else { Console.Write($"{N1} + {N2} = {result} - odd"); }
            }
            else if (symbol == "-") {
                result = N1 - N2;
                if (result % 2 == 0) { Console.Write($"{N1} - {N2} = {result} - even"); }
                else { Console.Write($" {N1} - {N2} = {result} - odd"); }
            }
            else if (symbol == "*") {
                result = N1 * N2;
                if (result % 2 == 0) { Console.Write($"{N1} * {N2} = {result} - even"); }
                else { Console.Write($"{N1} * {N2} = {result} - odd"); }
            }
            else if (symbol == "/") {
                result = N1 / N2;
                if (N1 == 0)
                {
                    Console.WriteLine($"Cannot divide {N2} by zero");
                }
                else if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} / {N2} = {result:f2}");
                }
            }
            else if (symbol == "%") {
                result = N1 % N2;
                if (N1 == 0)
                {
                    Console.WriteLine($"Cannot divide {N2} by zero");
                }
                else if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} % {N2} = {result:f2}");
                }
            }
            else{
                Console.WriteLine("Error");
            }

            //Zadacha 07. Hotel Room




            //Zadacha 08. On Time for the Exam



            //Zadacha 09. Ski Trip



        }
        }
    }