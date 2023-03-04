namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args) {
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

    ////Zadacha 01. Day of Week
    //int day = int.Parse(Console.ReadLine());
    //switch (day)
    //{
    //    case 1: Console.Write("Monday");
    //        break;
    //    case 2: Console.Write("Tuesday");
    //        break;
    //    case 3: Console.Write("Wednesday");
    //        break;
    //    case 4: Console.Write("Thursday");
    //        break;
    //    case 5: Console.Write("Friday");
    //        break;
    //    case 6: Console.Write("Saturday");
    //        break;
    //    case 7: Console.Write("Sunday");
    //        break;
    //    default:
    //        Console.Write("Error");
    //        break;
    //}

    ////Zadacha 02.Weekend or Working Day
    //string day = Console.ReadLine();
    //switch (day)
    //{
    //    case "Monday":
    //    case "Tuesday":
    //    case "Wednesday":
    //    case "Thursday":
    //    case "Friday":Console.Write("Working day");
    //        break;
    //    case "Saturday":
    //    case "Sunday":Console.Write("Weekend");
    //        break;
    //    default:Console.WriteLine("Error");
    //        break;
    //}

    ////Zadacha 03. Animal Type
    //string animal = Console.ReadLine();
    //switch (animal)
    //{
    //    case "dog": Console.WriteLine("mammal");
    //        break;
    //    case "snake":
    //    case "tortoise":
    //    case "crocodile":Console.WriteLine("reptile");
    //        break;
    //    default: Console.WriteLine("unknown");
    //        break;
    //}

    ////Zadacha 04. Personal Titles
    //double age = double.Parse(Console.ReadLine());
    //string sex = Console.ReadLine();
    //if (sex=="m"&&age>=16){
    //    Console.WriteLine("Mr.");
    //}
    //else if (sex == "m" && age < 16){
    //    Console.WriteLine("Master");
    //}
    //else if(sex == "f"&& age >= 16){
    //    Console.WriteLine("Ms.");
    //}
    //else{
    //    Console.WriteLine("Miss");
    //}

    ////Zadacha 05. Small Shop
    //string product = Console.ReadLine();
    //string city = Console.ReadLine();
    //double quantity = double.Parse(Console.ReadLine());
    //if (city == "Sofia") {
    //    if (product == "coffee") {
    //        Console.WriteLine(quantity * 0.50);
    //    }
    //    else if (product == "water") {
    //        Console.WriteLine(quantity * 0.80);
    //    }
    //    else if (product == "beer") {
    //        Console.WriteLine(quantity * 1.20);
    //    }
    //    else if (product == "sweets") {
    //        Console.WriteLine(quantity * 1.45);
    //    }
    //    else {
    //        Console.WriteLine(quantity * 1.60);
    //    }
    //}
    //else if (city == "Plovdiv") {
    //    if (product == "coffee") {
    //        Console.WriteLine(quantity * 0.40);
    //    }
    //    else if (product == "water") {
    //        Console.WriteLine(quantity * 0.70);
    //    }
    //    else if (product == "beer") {
    //        Console.WriteLine(quantity * 1.15);
    //    }
    //    else if (product == "sweets") {
    //        Console.WriteLine(quantity * 1.30);
    //    }
    //    else {
    //        Console.WriteLine(quantity * 1.50);
    //    } 
    //}
    //else {
    //    if (product == "coffee") {
    //        Console.WriteLine(quantity * 0.45);
    //    }
    //    else if (product == "water") {
    //        Console.WriteLine(quantity * 0.70);
    //    }
    //    else if (product == "beer") {
    //        Console.WriteLine(quantity * 1.10);
    //    }
    //    else if (product == "sweets") {
    //        Console.WriteLine(quantity * 1.35);
    //    }
    //    else {
    //        Console.WriteLine(quantity * 1.55);
    //    }
    //}


    ////Zadacha 06. Number in Range
    //double num = double.Parse(Console.ReadLine());
    //if (num >= -100 && num <= 100 && num != 0){
    //    Console.WriteLine("Yes");
    //}
    //else{
    //    Console.WriteLine("No");
    //}

    ////Zadacha 07.Working Hours
    //double timeOfDay = double.Parse(Console.ReadLine());
    //string day = Console.ReadLine();
    //if (timeOfDay>=10&&timeOfDay<=18&&day!="Saturday"&&day!="Sunday")
    //{
    //    Console.WriteLine("open");
    //}
    //else {
    //    Console.WriteLine("closed");
    //}

    ////Zadacha 08.Cinema Ticket
    //string dayOfWeek = Console.ReadLine();
    //switch (dayOfWeek)
    //{
    //    case "Monday": Console.WriteLine(12);
    //        break;
    //    case "Tuesday":Console.WriteLine(12);
    //        break;
    //    case "Wednesday":Console.WriteLine(14);
    //        break;
    //    case "Thursday": Console.WriteLine(14);
    //        break;
    //    case "Friday": Console.WriteLine(12);
    //        break;
    //    case "Saturday":Console.WriteLine(16);
    //        break;            
    //    default: Console.Write(16);
    //        break;
    //}


    ////Zadacha 09. Fruit or Vegetable
    //string item = Console.ReadLine();
    //switch (item)
    //{
    //    case "banana":
    //    case "apple":
    //    case "kiwi":
    //    case "cherry":
    //    case "lemon":
    //    case "grapes": Console.WriteLine("fruit");
    //        break;
    //    case "tomato":
    //    case "cucumber":
    //    case "pepper":
    //    case "carrot": Console.WriteLine("vegetable");
    //        break;
    //    default: Console.WriteLine("unknown");
    //        break;
    //}


    ////Zadacha 10. Invalid Number
    //double num = double.Parse(Console.ReadLine());
    //if (num==0||num>=100&&num<=200){
    //}
    //else{
    //    Console.WriteLine("invalid");
    //}

    ////Zadacha 11. Fruit Shop
    //string item = Console.ReadLine();
    //string day = Console.ReadLine();
    //double quantity = double.Parse(Console.ReadLine());
    //switch (day)
    //{
    //    case "Monday":
    //    case "Tuesday":
    //    case "Wednesday":
    //    case "Thursday":
    //    case "Friday":day = "Weekday";
    //        break;
    //    case "Saturday":
    //    case "Sunday": day = "Weekend";
    //        break;
    //    default:Console.WriteLine("error");
    //        break;
    //}
    //if (day == "Weekday")
    //{
    //    switch (item)
    //    {
    //        case "banana": Console.WriteLine($"{2.50 * quantity:f2}");
    //            break;
    //        case "apple": Console.WriteLine($"{1.20 * quantity:f2}");
    //            break;
    //        case "orange": Console.WriteLine($"{0.85 * quantity:f2}");
    //            break;
    //        case "grapefruit": Console.WriteLine($"{1.45 * quantity:f2}");
    //            break;
    //        case "kiwi": Console.WriteLine($"{2.70 * quantity:f2}");
    //            break;
    //        case "pineapple":Console.WriteLine($"{5.50 * quantity:f2}");
    //            break;
    //        case "grapes":Console.WriteLine($"{3.85 * quantity:f2}");
    //            break;
    //        default:Console.WriteLine("error");
    //            break;
    //    }
    //}
    //else if (day == "Weekend"){
    //    switch (item)
    //    {
    //        case "banana":
    //            Console.WriteLine($"{2.70 * quantity:f2}");
    //            break;
    //        case "apple":
    //            Console.WriteLine($"{1.25 * quantity:f2}");
    //            break;
    //        case "orange":
    //            Console.WriteLine($"{0.90 * quantity:f2}");
    //            break;
    //        case "grapefruit":
    //            Console.WriteLine($"{1.60 * quantity:f2}");
    //            break;
    //        case "kiwi":
    //            Console.WriteLine($"{3.00 * quantity:f2}");
    //            break;
    //        case "pineapple":
    //            Console.WriteLine($"{5.60 * quantity:f2}");
    //            break;
    //        case "grapes":
    //            Console.WriteLine($"{4.20*quantity:f2}");
    //            break;
    //        default:
    //            Console.WriteLine("error");
    //            break;
    //    }
    //}
    //else{}

    ////Zadacha 12. Trade Commissions
    //string city = Console.ReadLine();
    //double sum = double.Parse(Console.ReadLine());
    //if (city == "Sofia"){
    //    if (sum >=0&&sum<=500){
    //        Console.WriteLine($"{sum*0.05:f2}");
    //    }
    //    else if (sum >500&&sum<=1000){
    //        Console.WriteLine($"{sum * 0.07:f2}");
    //    }
    //    else if (sum>1000&&sum<=10000){
    //        Console.WriteLine($"{sum * 0.08:f2}");
    //    }
    //    else if (sum>10000){
    //        Console.WriteLine($"{sum * 0.12:f2}");
    //    }
    //    else{
    //        Console.WriteLine("error");
    //    }
    //}
    //else if (city == "Varna"){
    //    if (sum >= 0 && sum <= 500){
    //        Console.WriteLine($"{sum * 0.045:f2}");
    //    }
    //    else if (sum > 500 && sum <= 1000){
    //        Console.WriteLine($"{sum * 0.075:f2}");
    //    }
    //    else if (sum > 1000 && sum <= 10000){
    //        Console.WriteLine($"{sum * 0.10:f2}");
    //    }
    //    else if (sum > 10000){
    //        Console.WriteLine($"{sum * 0.13:f2}");
    //    }
    //    else{
    //        Console.WriteLine("error");
    //    }
    //}
    //else if (city == "Plovdiv"){
    //    if (sum >= 0 && sum <= 500){
    //        Console.WriteLine($"{sum * 0.055:f2}");
    //    }
    //    else if (sum > 500 && sum <= 1000){
    //        Console.WriteLine($"{sum * 0.08:f2}");
    //    }
    //    else if (sum > 1000 && sum <= 10000){
    //        Console.WriteLine($"{sum * 0.12:f2}");
    //    }
    //    else if (sum > 10000){
    //        Console.WriteLine($"{sum * 0.145:f2}");
    //    }
    //    else{
    //        Console.WriteLine("error");
    //    }
    //}
    //else{
    //    Console.WriteLine("error");
    //}


}
    }
}