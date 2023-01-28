namespace Conditions {
    internal class Program {
        static void Main(string[] args) {
            // Sample usage of 'switch' to execute selected function
            Console.WriteLine("Select sample:");
            Console.WriteLine("1. 'if'");
            Console.WriteLine("1e. 'if' exercise");
            Console.WriteLine("2. 'if...else'");
            Console.WriteLine("2e. 'if...else' exercise");
            Console.WriteLine("3. 'if...else' setting a variable'");
            Console.WriteLine("4. 'if' with more checks");
            Console.WriteLine("5. 'if' with boolean variable in the condition -----");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    IfSample();
                    break;
                case "1e":
                    IfExercise();
                    break;
                case "2":
                    IfElseSample();
                    break;
                case "2e":
                    IfElseExercise();
                    break;
                case "3":
                    IfElseSettingVariableSample();
                    break;
                case "4":
                    IfWithMoreChecks();
                    break;
                case "5":
                    IfWithBooleanVariableInTheCondition();
                    break;
                default:
                    Console.WriteLine("Choose from one of the available options");
                    break;
            }
        }

        static void IfSample() {
            Console.WriteLine("----- 'if' -----");
            Console.WriteLine("Example of a condition that checks whether a variable has value greater than 10 and if yes - executes a block of code:");
            Console.WriteLine("if (varName > 10) {");
            Console.WriteLine("    Console.WriteLine(\"The varName is greater than 10\");");
            Console.WriteLine("}");
            Console.WriteLine("The conditions in C# allow execution of a block of code to happen only if certain condition is met");
            Console.WriteLine("For example a warning must be shown if a value of a temperature is greater than 80");
            Console.WriteLine("One of the most adopted syntax form of condition checks is using the keyword 'if' followed by the condition in brackets followed by a block of code");
            Console.WriteLine("The condition expression must return 'bool' type like 'x > 50' or 'y == 5'");
            Console.WriteLine("If the condition returns 'true', the block of the code will be executed, otherwise it will not");

            Console.WriteLine("Enter a temperature value. If it is greater than 80, a warning will be shown");
            double temperature = double.Parse(Console.ReadLine());
            if (temperature > 80) {
                Console.WriteLine("Warning: The temperature is above 80");
            }

            Console.WriteLine("Enter a name. If it is 'John', a greeting will be shown");
            string name = Console.ReadLine();
            if (name == "John") {
                Console.WriteLine("Greetings John!");
            }
        }

        static void IfExercise() {
            // TODO: Receive an age value from the console
            //       If it is greater than 17 show "Allowed"

            // TODO: Receive fruit name from the console
            //       If it is "cherry", show "Sweet"
        }

        static void IfElseSample() {
            Console.WriteLine("----- 'if...else' -----");
            Console.WriteLine("Example of execution of block of code if a condition is true or if it is false:");
            Console.WriteLine("if (varName > 10) {");
            Console.WriteLine("    Console.WriteLine(\"The varName is greater than 10\");");
            Console.WriteLine("} else {");
            Console.WriteLine("    Console.WriteLine(\"The varName is not greater than 10\");");
            Console.WriteLine("}");
            Console.WriteLine("Sometimes one block of code must be performed when the condition is true and another one when the condition is false");
            Console.WriteLine("For this, the keyword 'else' is used followed by a block of code");

            Console.WriteLine("Enter a temperature value. If it is greater than 80, a warning will be shown, otherwise an informational message");
            double temperature = double.Parse(Console.ReadLine());
            if (temperature > 80) {
                Console.WriteLine("Warning: The temperature is above 80");
            } else {
                Console.WriteLine("Information: The temperature is not above 80");
            }
        }

        static void IfElseExercise() {
            // TODO: Come up with your own sample for exercise
        }

        static void IfElseSettingVariableSample() {
            Console.WriteLine("----- 'if...else' setting a variable -----");
            Console.WriteLine("Example of setting a variable value conditionally - setting the discount percent when the price is greater than 100 or 3 otherwise");
            Console.WriteLine("if (price > 100) {");
            Console.WriteLine("    discount = 15;");
            Console.WriteLine("} else {");
            Console.WriteLine("    discount = 3;");
            Console.WriteLine("}");
            Console.WriteLine("Often the if...else is used to set the value of a variable that is used later in the code");
            Console.WriteLine("The variable is declared before the 'if' and used after the 'if...else' ends its execution");

            Console.WriteLine("Enter a price. If it is greater than 300, the discount will be 10%, otherwise the discount will be 3%:");

            // We use the type 'decimal' because we are working with money values - for such kind of calculations, 'decimal' is the right type
            decimal price = decimal.Parse(Console.ReadLine());
            decimal discountPercent;
            if (price > 300) {
                discountPercent = 10;
            } else {
                discountPercent = 3;
            }
            decimal discountValue = price * (discountPercent / 100);
            decimal total = price - discountValue;
            Console.WriteLine($"Price = {price}");
            Console.WriteLine($"Discount for this price = {discountPercent}% ({discountValue})");
            Console.WriteLine($"Total = {total}");
        }

        static void IfWithMoreChecks() {
            Console.WriteLine("----- 'if' with more checks -----");
            Console.WriteLine("Sample 'if' with 2 checks in the condition:");
            Console.WriteLine("if (price >= 100 && price <= 300) {");
            Console.WriteLine("    discount = 15;");
            Console.WriteLine("} else {");
            Console.WriteLine("    discount = 3;");
            Console.WriteLine("}");
            Console.WriteLine("The 'if' condition can have multiple checks used with logical operators");
            Console.WriteLine("For example when we need to check whether a variable is between 10 and 20 we need to check both whether it is greater than or equal to 10 and at the same time less than or equal to 20");
            Console.WriteLine("In such cases the condition will have two checks with logical operator 'and' (&& in C#) and would look like 'if (variable >= 10 && variable <= 20) { ... }'");

            Console.WriteLine("Enter a price. If it is between 50 and 100, the discount will be 8%, otherwise it will be 2%:");
            decimal price = decimal.Parse(Console.ReadLine());
            decimal discountPercent;
            if (price >= 50 && price <= 100) {
                // The prices is in the interval [50, 100]
                discountPercent = 8;
            } else {
                discountPercent = 2;
            }
            decimal discountValue = price * (discountPercent / 100);
            decimal total = price - discountValue;
            Console.WriteLine($"Price = {price}");
            Console.WriteLine($"Discount for this price = {discountPercent}% ({discountValue})");
            Console.WriteLine($"Total = {total}");
        }

        static void IfWithBooleanVariableInTheCondition() {
            Console.WriteLine("----- 'if' with boolean variable in the condition -----");
            Console.WriteLine("// Simply set the variable for Get the value of the variablebool customerIsLoyal = true;");
            Console.WriteLine("if (numberOfComplains == 0) {");
            Console.WriteLine("    customerIsLoyal = true;");
            Console.WriteLine("}");
            Console.WriteLine("if (customerIsLoyal) {");
            Console.WriteLine("    discount = 6;");
            Console.WriteLine("} else {");
            Console.WriteLine("    discount = 2;");
            Console.WriteLine("}");

            Console.WriteLine("Determining the discount based on the price and on the total of all the purchases of the customer");
            Console.WriteLine("If the price is greater than 200 and total customer purchases is more than 1000, the discount will be 10%, otherwise it will be 3%");
            Console.WriteLine("Enter the price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the total of all the customer purchases until now:");
            decimal totalOfAllCustomerPurchases = decimal.Parse(Console.ReadLine());
            bool customerSpentALot;
            if (totalOfAllCustomerPurchases > 10000) {
                customerSpentALot = true;
            } else {
                customerSpentALot = false;
            }
            // Notice there is no comparison for customerSpentALot because it is a boolean which evaluates to 'true' or 'false'
            // This kind of comparison:
            // if (price >= 200 && customerSpentALot)
            // is equivalent to:
            // 'if (price > 200 && customerSpentALot == true)'
            decimal discountPercent;
            if (price >= 200 && customerSpentALot) {
                discountPercent = 10;
            } else {
                discountPercent = 3;
            }
            Console.WriteLine($"Customer spent a lot ? {customerSpentALot}");
            Console.WriteLine($"Discount % = {discountPercent}");
        }

        static void IfWithMoreChecks2() {
            Console.WriteLine("----- 'if' with more checks 2 -----");
            Console.WriteLine("Sample 'if' with 2 checks in the condition using different variables:");
            Console.WriteLine("if (price >= 100 && totalCustomerPurchases > 1000) {");
            Console.WriteLine("    discount = 6;");
            Console.WriteLine("} else {");
            Console.WriteLine("    discount = 2;");
            Console.WriteLine("}");
            Console.WriteLine("The 'if' condition checks are not constrained for a single variable - they can contain many variables");
            Console.WriteLine("For example when we need to check whether one variable is greater than 25 and another variable greater than 500");

            Console.WriteLine("Enter a price. If it is between 50 and 100, the discount will be 8%, otherwise it will be 2%:");
            decimal price = decimal.Parse(Console.ReadLine());
            decimal discountPercent;
            if (price >= 50 && price <= 100) {
                // The prices is in the interval [50, 100]
                discountPercent = 8;
            } else {
                discountPercent = 2;
            }
            decimal discountValue = price * (discountPercent / 100);
            decimal total = price - discountValue;
            Console.WriteLine($"Price = {price}");
            Console.WriteLine($"Discount for this price = {discountPercent}% ({discountValue})");
            Console.WriteLine($"Total = {total}");
        }


        //static void IfElseIfElseSample() {
        //    Console.WriteLine("----- 'if...elseif...else' -----");
        //    Console.WriteLine("Example of determining the state of ");
        //    Console.WriteLine("Sometimes more than two conditions must be checked and different code executed for each one of them");
        //    Console.WriteLine("In such cases we can use 'if' with combination with 'elseif' and eventually 'else'");
        //    Console.WriteLine("For example, if we need to determine whether a value of a temperature is in lower range, warning range or critical range");
        //    //Console.WriteLine("The execution of 'if'")
        //    Console.WriteLine("if (price > 100) {");
        //    Console.WriteLine("    discount = 15;");
        //    Console.WriteLine("} else {");
        //    Console.WriteLine("    discount = 3;");
        //    Console.WriteLine("}");
        //    Console.WriteLine("Often the if...else is used to set the value of a variable that is used later in the code");
        //    Console.WriteLine("The variable is declared before the 'if' and used after the 'if...else' ends its execution");
        //}
    }
}