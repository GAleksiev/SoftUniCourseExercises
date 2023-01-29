namespace Conditions {
    internal class Program {
        static void Main(string[] args) {
            // Sample usage of 'switch' to execute selected function
            Console.WriteLine("Select option:");
            Console.WriteLine("1. 'if'");
            Console.WriteLine("1e. 1. exercise");
            Console.WriteLine("2. 'if...else'");
            Console.WriteLine("2e. 2. exercise");
            Console.WriteLine("3. 'if...else' setting a variable");
            Console.WriteLine("3e. 3. exercise");
            Console.WriteLine("4. 'if' with more checks");
            Console.WriteLine("4e. 4. exercise");
            Console.WriteLine("5. 'if' with boolean variable in the condition");
            Console.WriteLine("5e. 5. exercise");
            Console.WriteLine("6. 'if...else if...else'");
            Console.WriteLine("6e. 6. exercise");
            Console.WriteLine("7. 'if...else' implemented with ternary conditional operator");
            Console.WriteLine("7e. 7. exercise");
            Console.WriteLine("8. 'switch'");
            Console.WriteLine("8e. 8. exercise");
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
                case "3e":
                    IfElseSettingVariableExercise();
                    break;
                case "4":
                    IfWithMoreChecksSample();
                    break;
                case "4e":
                    IfWithMoreChecksExercise();
                    break;
                case "5":
                    IfWithBooleanVariableInTheConditionSample();
                    break;
                case "5e":
                    IfWithBooleanVariableInTheConditionExercise();
                    break;
                case "6":
                    IfElseIfElseSample();
                    break;
                case "6e":
                    IfElseIfElseExercise();
                    break;
                case "7":
                    IfElseWithTernaryConditionalOperatorSample();
                    break;
                case "8":
                    SwitchSample();
                    break;
                case "8e":
                    SwitchExercise();
                    break;
                default:
                    Console.WriteLine("Selected option is not found. Choose from one of the available options.");
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

            Console.WriteLine("> Enter a temperature value. If it is greater than 80, a warning will be shown");
            double temperature = double.Parse(Console.ReadLine());
            if (temperature > 80) {
                Console.WriteLine("Warning: The temperature is above 80");
            }

            Console.WriteLine("> Enter a name. If it is 'John', a greeting will be shown");
            string name = Console.ReadLine();
            if (name == "John") {
                Console.WriteLine("Greetings John!");
            }
        }

        static void IfExercise() {
            // TODO: Get an age value from the console
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

            Console.WriteLine("> Enter a temperature value. If it is greater than 80, a warning will be shown, otherwise an informational message");
            double temperature = double.Parse(Console.ReadLine());
            if (temperature > 80) {
                Console.WriteLine("Warning: The temperature is above 80");
            } else {
                Console.WriteLine("Information: The temperature is not above 80");
            }
        }

        static void IfElseExercise() {
            // TODO: Get an age value from the console
            //       If less than 18 show "Not allowed"
            //       Else show "Allowed"

            // TODO: Get decimal value from the console (stotinki)
            //       If it is less than 100 show "<the value> stotinki"
            //       Else show "<the value in leva> leva"
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

            Console.WriteLine("> Enter the price. If it is greater than 300, the discount will be 10%, otherwise the discount will be 3%:");
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

        static void IfElseSettingVariableExercise() {
            // TODO: An order for up to 5 items can be fulfilled for one day
            //       For each extra item ordered, the delivery delay increases with 2 days
            //       Ask the user for the number of items, calculate the delay in the 'if' and 'else' code blocks
            //       and show it with Console.WriteLine after the 'if...else'
        }

        static void IfWithMoreChecksSample() {
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

            Console.WriteLine("> Enter a price. If it is between 50 and 100, the discount will be 8%, otherwise it will be 2%:");
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

            Console.WriteLine();
            Console.WriteLine("It is possible to have more complex conditions which combine logical 'and' and logical 'or' like:");
            Console.WriteLine("if ((price >= 100 && price < 500) || (price >= 1300 && price <= 2000)) { ... }");
            Console.WriteLine("The above condition will be evaluated to true and the code will be executed, if the price is in one of the ranges [100, 500] or [1300, 2000]");
            Console.WriteLine("Enclose the related comparisons in their own brackets to set the precedence of actions - it also improves readability");

            Console.WriteLine();
            Console.WriteLine("> Enter age");
            int age = int.Parse(Console.ReadLine());
            if ((age >= 18 && age <= 25) || (age >= 30 && age <= 32)) {
                // People in ages 18-25 or 30-32
                Console.WriteLine("People 18-25 or 30-32 have to complete a questionnaire");
            } else {
                // All other age ranges can start the course
                Console.WriteLine("You are eligible to start the course");
            }
        }

        static void IfWithMoreChecksExercise() {
            // TODO: Ask the user for its age
            //       For people aged 18 to 60 (inclusive) the price for the bus ticket is 2 euro
            //       For the rest is 0.5 euro
            //       Calculate the price according to the age and show it
        }

        static void IfWithBooleanVariableInTheConditionSample() {
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

            Console.WriteLine();
            Console.WriteLine("Determining the discount based on the price and on the total of all the purchases of the customer");
            Console.WriteLine("If the price is greater than 200 and total customer purchases is more than 1000, the discount will be 10%, otherwise it will be 3%");
            Console.WriteLine("> Enter the price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("> Enter the total of all the customer purchases until now:");
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

            Console.WriteLine();
            Console.WriteLine("Often the 'if' condition use negation of boolean variables to check whether their value is 'false'");
            Console.WriteLine("Negation is performed by placing exclamation mark before the name of the variable like this:");
            Console.WriteLine("if (!hasCriminalPast) { ... }");
            Console.WriteLine("The code block of the above if will be executed if the person does not have crimial past");

            Console.WriteLine();
            Console.WriteLine("> Enter age");
            int age = int.Parse(Console.ReadLine());
            bool isAccessRestricted;
            if (age < 18) {
                isAccessRestricted = true;
            } else {
                isAccessRestricted = false;
            }
            if (!isAccessRestricted) {
                // The access is not restricted
                Console.WriteLine("You are allowed to visit the club");
            } else {
                Console.WriteLine("You need to be at least 18 to visit the club");
            }
        }

        static void IfWithBooleanVariableInTheConditionExercise() {
            // TODO: Declare variable of type bool
            //       Ask the user whether it will pay with credit card or cash
            //       Set the boolean variable to true if the payment is with credit card and false otherwise
            //       Ask the user for the price
            //       If the price is greater than 200 and the payment will be made with credit card
            //       Apply discount of 10%
            //       Calculate and show the final price
        }

        static void IfElseIfElseSample() {
            Console.WriteLine("----- 'if...else if...else' -----");
            Console.WriteLine("Sample check of price range:");
            Console.WriteLine("if (price < 200) {");
            Console.WriteLine("    Console.WriteLine(\"The price range is 'Low'\");");
            Console.WriteLine("} else if (price >=200 && price <700) {");
            Console.WriteLine("    Console.WriteLine(\"The price range is 'Medium'\");");
            Console.WriteLine("} else if (price >=700 && price <1500) {");
            Console.WriteLine("    Console.WriteLine(\"The price range is 'High'\");");
            Console.WriteLine("} else {");
            Console.WriteLine("    Console.WriteLine(\"The price range is 'Top'\");");
            Console.WriteLine("}");
            Console.WriteLine("Sometimes more than 2 conditional code blocks are needed to describe more complex scenarios");
            Console.WriteLine("Like checking conditions for matching 3 or more ranges");
            Console.WriteLine("In such cases one or more 'else if' can be added just after the first 'if' to continue with checking of other conditions");
            Console.WriteLine("The last item in this sequence could be 'else' for executing code if none of the above conditions was not met but 'else' block is not required");
            Console.WriteLine("In such constructions conditions are checked from top to bottom and if some of them evaluates to 'true'");
            Console.WriteLine("Its code block is executed and all other conditions are skipped and the program continues its execution from the line which is after the last 'else if' (or 'else' if provided as last item)");

            // From a table in https://en.wikipedia.org/wiki/Stellar_classification
            Console.WriteLine("> Enter the temperature of a star (in Kelvins)");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature >= 2400 && temperature < 3700) {
                Console.WriteLine("Star class 'C', emitted light 'orange red'");
            } else if (temperature >= 3700 && temperature < 5200) {
                Console.WriteLine("Star class 'K', emitted light 'light orange'");
            } else if (temperature >= 5200 && temperature < 6000) {
                Console.WriteLine("Star class 'G', emitted light 'yellow'");
            } else if (temperature >= 6000 && temperature < 7500) {
                Console.WriteLine("Star class 'F', emitted light 'yellow white'");
            } else if (temperature >= 7500 && temperature < 10000) {
                Console.WriteLine("Star class 'A', emitted light 'white'");
            } else if (temperature >= 10000 && temperature < 30000) {
                Console.WriteLine("Star class 'B', emitted light 'blue white'");
            } else if (temperature >= 30000) {
                Console.WriteLine("Star class 'O', emitted light 'blue'");
            } else {
                // The 'else' will be executed if none of the above 'if' or 'else if' blocks conditions was met
                // The 'else' block is not required
                Console.WriteLine($"Temperature {temperature}K is not part of the table");
            }
        }

        static void IfElseIfElseExercise() {
            // TODO: The fine for driving with:
            //       0 to 30 km/h (30 inclusive) above the limit -> 500 euro
            //       more than 30 to 80 km/h (80 inclusive) above the limit -> 2000 euro
            //       more than 80 km/h above the limit -> 6000 euro + 200 euro for each km/h above 80
            //       Ask the user for the limit and detected speed, calculate the fine and show it
            //       Extra:
            //       After the fine is calculated, ask a third question whether the speed was detected in urban area
            //       if yes - triple the fine and show it
        }

        static void IfElseWithTernaryConditionalOperatorSample() {
            Console.WriteLine("----- 'if...else' with ternary conditional operator -----");
            Console.WriteLine("The if...else construct can be simplified and executed on a single line if all that is made in the code blocks is setting a value to a variable");
            Console.WriteLine("It can replace the following simple if...else code blocks:");
            Console.WriteLine("decimal discountPercent;");
            Console.WriteLine("if (price > 100) {");
            Console.WriteLine("    discountPercent = 7;");
            Console.WriteLine("} else {");
            Console.WriteLine("    discountPercent = 2;");
            Console.WriteLine("}");
            Console.WriteLine();
            Console.WriteLine("With the following:");
            Console.WriteLine("decimal discountPercent = price > 100 ? 7 : 2;");
            Console.WriteLine("The code on the right side of the '=' contains:");
            Console.WriteLine("- The condition 'price > 100'");
            Console.WriteLine("- A question mark '?'");
            Console.WriteLine("- What to return if the condition evaluates to true (in our case if price is greater than 100 - 7 will be returned)");
            Console.WriteLine("- A colon ':'");
            Console.WriteLine("- What to return if the condition evaluates to false (in our case if price is not greater than 100 - 2 will be returned)");
            Console.WriteLine("It can be read like this:");
            Console.WriteLine("decimal discountPercent = '(is price > 100) ? (if yes, return 7) : (if no, return 2)'");
            Console.WriteLine("The ternary conditional operator must return something so the values both before and after the color ':' must be provided");

            Console.WriteLine("> Enter a price");
            decimal price = decimal.Parse(Console.ReadLine());
            decimal discountPercent = price > 100 ? 7 : 2;
            Console.WriteLine($"The discount for price {price} is {discountPercent}%");
        }

        static void SwitchSample() {
            Console.WriteLine("----- 'switch' -----");
            Console.WriteLine("switch is similar to 'if...else if...else' but its condition can only compare with constant values and not with other variables");
            Console.WriteLine("Example:");
            Console.WriteLine("bool isAdmin = false;");
            Console.WriteLine("Console.WriteLine(\"Enter role name\");");
            Console.WriteLine("string role = Console.ReadLine();");
            Console.WriteLine("switch (role) {");
            Console.WriteLine("    case \"admin\":");
            Console.WriteLine("        Console.WriteLine(\"You are granted with full rights\");");
            Console.WriteLine("        isAdmin = true;");
            Console.WriteLine("        break;");
            Console.WriteLine("    case \"reporter\":");
            Console.WriteLine("        Console.WriteLine(\"You are granted rights to see reports\");");
            Console.WriteLine("        break;");
            Console.WriteLine("    case \"customer\":");
            Console.WriteLine("        Console.WriteLine(\"Your rights are limited\");");
            Console.WriteLine("        break;");
            Console.WriteLine("    default:");
            Console.WriteLine("        Console.WriteLine(\"The specified role is unknown\")");
            Console.WriteLine("        break;");
            Console.WriteLine("}");

            Console.WriteLine();
            Console.WriteLine("What means that it can compare only with constant values is that you can't use variables in the 'case' condition:");
            Console.WriteLine("bool isAdmin = false;");
            Console.WriteLine("string adminRoleName = \"admin\"");
            Console.WriteLine("Console.WriteLine(\"Enter role name\");");
            Console.WriteLine("string role = Console.ReadLine();");
            Console.WriteLine("switch (role) {");
            Console.WriteLine("    case adminRoleName:   <----- this will cause compilation error");
            Console.WriteLine("        Console.WriteLine(\"You are granted with full rights\");");
            Console.WriteLine("        isAdmin = true;");
            Console.WriteLine("        break;");

            Console.WriteLine();
            Console.WriteLine("The 'switch' statement is followed by the variable that must used in the conditions '(role)'");
            Console.WriteLine("Then one or more 'case' statements followed by the value to which the variable will be compared (in our case these are the strings \"admin\", \"reporter\" and \"customer\")");
            Console.WriteLine("Each 'case' statement ends with colon ':' and has a block of code which should end with \"break;\"");
            Console.WriteLine("Optionally at the end a 'default' keyword can be used - it does not have a condition constant because it plays the role of 'else' in 'if...else' construct - will be executed if none of the above cases evaluates to true");
            Console.WriteLine("It is also possible to use conditions like <, <=, >, >= or combination of them with numbers like:");
            Console.WriteLine("Console.WriteLine(\"Enter role name\"");
            Console.WriteLine("int price = int.Parse(Console.ReadLine());");
            Console.WriteLine("switch (price) {");
            Console.WriteLine("    case < 100:");
            Console.WriteLine("        Console.WriteLine(\"Less than 100\");");
            Console.WriteLine("        break;");
            Console.WriteLine("    case >= 100 and < 1000:");
            Console.WriteLine("        Console.WriteLine(\"Greater than or equal to 100 but less than 1000\");");
            Console.WriteLine("        break;");
            Console.WriteLine("    case >= 1000 and < 5000:");
            Console.WriteLine("        Console.WriteLine(\"Greater than or equal to 1000 but less than 5000\");");
            Console.WriteLine("        break;");
            Console.WriteLine("    default:");
            Console.WriteLine("        Console.WriteLine(\"None of the above (appears to be greater than or equal to 5000)\")");
            Console.WriteLine("        break;");
            Console.WriteLine("}");

            Console.WriteLine();
            Console.WriteLine("Similarly to the 'if...else if...else', execution of 'switch' will finish when a 'case' is found which evaluates to true");

            Console.WriteLine();
            Console.WriteLine("It is possible for two 'case' statements to have the same block of code. Such cases looks like this:");
            Console.WriteLine("Console.WriteLine(\"Enter a name\");");
            Console.WriteLine("string name = Console.ReadLine();");
            Console.WriteLine("switch (name) {");
            Console.WriteLine("    case \"Alice\":");
            Console.WriteLine("        Console.WriteLine(\"Hello Alice\")");
            Console.WriteLine("        break;");
            Console.WriteLine("    case \"Homer\":");
            Console.WriteLine("    case \"Marge\":");
            Console.WriteLine("    case \"Bart\":");
            Console.WriteLine("    case \"Lisa\":");
            Console.WriteLine("    case \"Maggie\":");
            Console.WriteLine("        Console.WriteLine(\"It's nice to meet a Simpson's member\");");
            Console.WriteLine("        break;");
            Console.WriteLine("    case \"Bob\":");
            Console.WriteLine("        Console.WriteLine(\"Hello Bob\");");
            Console.WriteLine("        break;");
            Console.WriteLine("    default:");
            Console.WriteLine("        Console.WriteLine(\"I don't know you\")");
            Console.WriteLine("        break;");
            Console.WriteLine("}");

            Console.WriteLine();
            Console.WriteLine("The 4 'case' above can also be combined into single one like this:");
            Console.WriteLine("    case \"Homer\" or \"Marge\" or \"Bart\" or \"Lisa\" or \"Maggie\":");
            Console.WriteLine("        Console.WriteLine(\"It's nice to meet a Simpson's member\");");
            Console.WriteLine("        break;");

            Console.WriteLine();
            Console.WriteLine("> Enter price");
            decimal price = decimal.Parse(Console.ReadLine());
            decimal discountPercent;
            switch (price) {
                case <= 0:
                    Console.WriteLine("Negative or zero price");
                    discountPercent = 0;
                    break;
                case < 100:
                    // This case will be executed if the price is > 0 and < 100
                    // It is guaranteed that it is not 0 or less, because if it was, the case above
                    // would have been executed which means other cases will not be evaluated
                    discountPercent = 3;
                    break;
                case < 500:
                    // Similarly to the above, this case will be executed if the price is >=0 and < 500
                    discountPercent = 4;
                    break;
                case < 1000:
                    // Will be executed if the prices is >= 500 and < 1000
                    discountPercent = 6;
                    break;
                default:
                    // Will be executed if none of the above cases was evaluated to true
                    // Since all the above cases cover values < 1000
                    // This will be executed for values >= 1000
                    discountPercent = 9;
                    break;
            }
            Console.WriteLine($"Discount for the price {price} is {discountPercent}%");
        }

        static void SwitchExercise() {
            // TODO: Implement the logic in the method IfElseIfElseSample() for star classes but with 'switch'
        }
    }
}