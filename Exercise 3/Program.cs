namespace Exercise_3 {
    internal class Program {
        static void Main(string[] args) {

            //        using System;
            //                                        namespace HelloSoftuni
            //{
            //    internal class Program
            //    {
            //        static void Main(string[] args)
            //        {

            //            Write Code Here


            //                                                    }
            //    }
            //}

            //Zadacha 01. Seconds Sum
            //int firstTime = int.Parse(Console.ReadLine());
            //        int secondTime = int.Parse(Console.ReadLine());
            //        int thirdTime = int.Parse(Console.ReadLine());
            //        int totalTime = firstTime+secondTime+ thirdTime;
            //        int minutes = totalTime / 60;
            //        int seconds = totalTime % 60;
            //        if (seconds < 10) {
            //            Console.WriteLine($"{minutes}:0{seconds}");
            //        } else {
            //            Console.WriteLine($"{minutes}:{seconds}");
            //        }

            ////Zadacha 02. Bonus Score
            //double bonusScore = 0.0;
            //int number = int.Parse(Console.ReadLine());
            //if (number <= 100) {
            //    bonusScore = 5;
            //    if (number%2==0) {
            //        bonusScore = bonusScore +1;
            //        Console.WriteLine(bonusScore);
            //        Console.WriteLine(number + bonusScore);
            //    }
            //    else if (number%10==5) {
            //        bonusScore = bonusScore+2;
            //        Console.WriteLine(bonusScore);
            //        Console.WriteLine(number + bonusScore);
            //    }
            //    else {
            //        Console.WriteLine(bonusScore);
            //        Console.WriteLine(number + bonusScore);
            //    }
            //} else if (number <1000) {
            //    bonusScore = number * 0.2;
            //    if (number % 2 == 0) {
            //        bonusScore = bonusScore+1;
            //        Console.WriteLine(bonusScore);
            //        Console.WriteLine(number + bonusScore);
            //    } else if(number % 10 == 5) {
            //        bonusScore = bonusScore + 2;
            //        Console.WriteLine(bonusScore);
            //        Console.WriteLine(number + bonusScore);
            //    }
            //  else {
            //        Console.WriteLine(bonusScore);
            //        Console.WriteLine(number + bonusScore);
            //    }
            //}
            //else if (number >=1000){
            //    bonusScore = number * 0.1;
            //    if (number % 2 == 0) {
            //        bonusScore = bonusScore + 1;
            //        Console.WriteLine(bonusScore);
            //        Console.WriteLine(number + bonusScore);
            //    } else if (number % 10 == 5) {
            //        bonusScore = bonusScore + 2;
            //        Console.WriteLine(bonusScore);
            //        Console.WriteLine(number + bonusScore);
            //    } else {
            //        Console.WriteLine(bonusScore);
            //        Console.WriteLine(number + bonusScore);
            //    }
            //} else { Console.WriteLine("Error"); }

            ////Zadacha 03. Time + 15 Minutes

            //int hour = int.Parse(Console.ReadLine());
            //int minutes = int.Parse(Console.ReadLine());
            //minutes += hour * 60;
            //minutes += 15;
            //hour = minutes / 60;
            //minutes = minutes % 60;
            //if (hour >= 24) { hour = 0; }
            //Console.WriteLine($"{hour}:{minutes:D2}");

            ////Zadacha 04. Toy Shop

            //double excursionPrice = double.Parse(Console.ReadLine());
            //int puzzles = int.Parse(Console.ReadLine());
            //int dolls = int.Parse(Console.ReadLine());
            //int teddyBears = int.Parse(Console.ReadLine());
            //int minions = int.Parse(Console.ReadLine());
            //int trucks = int.Parse(Console.ReadLine());
            //double wholePrice;
            //int numOfToys = puzzles+dolls+teddyBears+minions+trucks;
            //double sumPrice = (puzzles*2.60) + (dolls*3) + (teddyBears*4.10) + (minions*8.20) + (trucks*2);
            //if(numOfToys >= 50) { wholePrice = (sumPrice - sumPrice * 0.25) - ((sumPrice - sumPrice * 0.25) * 0.1); } else { wholePrice = sumPrice - (sumPrice * 0.1); }
            //if (wholePrice >= excursionPrice) { Console.WriteLine($"Yes! {wholePrice - excursionPrice:f2} lv left.",2); } else { Console.WriteLine($"Not enough money! {excursionPrice - wholePrice:f2} lv needed."); }

            ////Zadacha 05. Godzilla vs. Kong

            //double movieBudget = double.Parse(Console.ReadLine());
            //int movieExtras = int.Parse(Console.ReadLine());
            //double extrasAttireCostPerPerson = double.Parse(Console.ReadLine());
            ////^ Required input.
            //double extrasAttireCost = extrasAttireCostPerPerson * movieExtras;
            ////^ Here we calculate the full price for the extras' attires (number or people multiplied by the cost of an attire for a single person).
            //double filmDecor = movieBudget * 0.1;
            ////^ filmDecor is a value given to us by the exercise.
            //double discount = extrasAttireCost * 0.1;
            ////^ discount is also a value given to us by the exercise.
            //if (movieExtras > 150) { extrasAttireCost -=discount;
            //    //^ If the extras are more than 150 people - a discount of 10% from the full price for the extras' attires is issued.
            //    if (filmDecor+extrasAttireCost<=movieBudget) {
            //        Console.WriteLine("Action!");
            //        Console.WriteLine($"Wingard starts filming with {movieBudget-(filmDecor+extrasAttireCost):f2} leva left.");
            //    } else {
            //        Console.WriteLine("Not enough money!");
            //        Console.WriteLine($"Wingard needs {(filmDecor + extrasAttireCost) - movieBudget:f2} leva more.");
            //    }
            //}

            //else {
            //    if (filmDecor + extrasAttireCost <= movieBudget) {
            //        Console.WriteLine("Action!");
            //        Console.WriteLine($"Wingard starts filming with {movieBudget - (filmDecor + extrasAttireCost):f2} leva left.");
            //    } else {
            //        Console.WriteLine("Not enough money!");
            //        Console.WriteLine($"Wingard needs {(filmDecor + extrasAttireCost) - movieBudget:f2} leva more.");
            //    }

            //}

            ////Zadacha 06. World Swimming Record

            //double recordInSeconds = double.Parse(Console.ReadLine());
            //        double distance = double.Parse(Console.ReadLine());
            //        double meterPerSecond = double.Parse(Console.ReadLine());

            //        double distanceTime = distance * meterPerSecond;
            //        double drag = Math.Floor((distance / 15)) * 12.5;
            //        double fullTime = distanceTime + drag;

            //        if (fullTime>=recordInSeconds)
            //        {
            //            Console.WriteLine($"No, he failed! He was {fullTime - recordInSeconds:f2} seconds slower.");
            //        }
            //        else
            //        {
            //             Console.WriteLine($"Yes, he succeeded! The new world record is {fullTime:f2} seconds.");
            //        }

            ////Zadacha 07. Shopping

            // 80 от 100 = някъде гърми?

            //double petersBudget = double.Parse(Console.ReadLine());
            //int gpuNum = int.Parse(Console.ReadLine());
            //int cpuNum = int.Parse(Console.ReadLine());
            //int ramNum = int.Parse(Console.ReadLine());

            //double gpuPrice = gpuNum * 250;
            //double cpuPrice = cpuNum * (gpuPrice * 0.35);
            //double ramPrice = ramNum * (gpuPrice * 0.1);
            //double discount = 0.15;
            //double fullPrice = gpuPrice + cpuPrice + ramPrice;
            //if (gpuNum > cpuNum)
            //{
            //    double discountPrice = fullPrice - (fullPrice * discount);
            //    if (petersBudget > discountPrice)
            //    {
            //        Console.WriteLine($"You have {petersBudget - discountPrice:f2} leva left!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Not enough money! You need {discountPrice - petersBudget:f2} leva more!");
            //    }
            //}
            //else
            //{
            //    if (petersBudget > fullPrice)
            //    {
            //        Console.WriteLine($"You have {petersBudget - fullPrice:f2} leva left!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Not enough money! You need {fullPrice - petersBudget:f2} leva more!");
            //    }
            //}

            ////Zadacha 08. Lunch Break
            
            /// 87 от 100 = някъде гърми?

            //string seriesName = Console.ReadLine();
            //int episodeDuration = int.Parse(Console.ReadLine());
            //int lunchBreak = int.Parse(Console.ReadLine());
            //// 8/8 - 1/8+1/4 = 5/8
            //double timeForSeries = lunchBreak * 5 / 8;
            //if (timeForSeries>=episodeDuration)
            //{
            //    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeForSeries - episodeDuration)} minutes free time.");
            //}
            //else
            //{
            //    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeDuration - timeForSeries)} more minutes.");

            //}

        }
    }
}