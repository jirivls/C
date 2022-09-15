using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace GreenFox
{
    class Program
    {
        //private static int GetDCountH()
        //{
        //    return dCountH;
        //}

        static void Main(string[] args)
        {
            
            // task1
            // Modify this program to greet you instead of the World!
            Console.WriteLine("Hello, Jiri!");
            Console.WriteLine();
            // task2
            // Modify this program to print Humpty Dumpty riddle correctly         
            Console.WriteLine("Humpty Dumpty had a great fall.");
            Console.WriteLine("Humpty Dumpty sat on a wall,");
            Console.WriteLine("All the king's horses and all the king's men");
            Console.WriteLine("Couldn't put Humpty together again.");
            Console.WriteLine();
            // task3
            // Greet 3 of your classmates with this program in three separate lines
            // like:
            string name1 = "Standa";
            string name2 = "Katka";
            string name3 = "Michal";

            Console.WriteLine("Hello " + name1 + "!");
            Console.WriteLine("Hello " + name2 + "!");
            Console.WriteLine("Hello " + name3 + "!");
            Console.WriteLine();

            //task4
            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line:
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)

            //bio
            string nameJV = "Jiri Volesky";
            int age = 30;
            double height = 1.98;

            Console.WriteLine("Jiri info");
            Console.Write(nameJV);
            Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine();

            //task5
            // Create a program that prints a few operations on two numbers: 22 and 13
            int number1 = 22;
            int number2 = 13;
            // Print the result of 13 added to 22
            int result1;
            result1 = number1 + number2;
            Console.Write("First result is: " + result1);
            Console.WriteLine();
            // Print the result of 13 substracted from 22
            int result2;
            result2 = number1 - number2;
            Console.Write("Second result is: " + result2);
            Console.WriteLine();
            // Print the result of 22 multiplied by 13
            int result3;
            result3 = number1 * number2;
            Console.Write("Third result is: " + result3);
            Console.WriteLine();
            // Print the result of 22 divided by 13 (as a decimal fraction)
            decimal result4;
            result4 = decimal.Divide(number1, number2);
            Console.Write("Fourth result is: " + result4);
            Console.WriteLine();
            // Print the integer part of 22 divided by 13
            int result5;
            result5 = number1 / number2;
            Console.Write("Fifth result is: " + result5);
            Console.WriteLine();
            // Print the remainder of 22 divided by 13
            int result6;
            result6 = number1 % number2;
            Console.Write("Sixth result is: " + result6);
            Console.WriteLine();

            //task6
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            int hdaily = 6;
            int days = 17 * 5;
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            int total = hdaily * days;
            Console.Write("Student hours spent on coding in average: " + total);
            Console.WriteLine();
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            double codeperc;
            double hweekly = 5 * 6;
            codeperc = Math.Round(hweekly / (52.0 / 100.0), 2);
            Console.Write("Percentage of semester spent on coding: " + codeperc);
            Console.WriteLine();

            //task7
            // Store your favorite number in a variable (as a number)
            // And print it like this: "My favorite number is: 8"
            int favn = 8;
            Console.WriteLine("My favourite number is: " + favn);
            Console.WriteLine();

            //task8
            // Swap the values of the variables
            int a = 123;
            int b = 526;
            (a, b) = (b, a);

            Console.WriteLine("Swapped number a: " + a);
            Console.WriteLine("Swapped number b " + b);
            Console.WriteLine();

            //task9
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;
            double bmi = Math.Round(massInKg / Math.Pow(heightInM, 2));
            Console.WriteLine("BMI is: " + bmi);
            Console.WriteLine();

            //task10
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean
            string mname = "Jiri Volesky";
            int mage = 30;
            double mheight = 1.98;
            bool married = false;
            Console.WriteLine("Name: " + mname);
            Console.WriteLine("Age: " + mage);
            Console.WriteLine("Height: " + mheight);
            Console.WriteLine("Married: " + married);
            Console.WriteLine();

            //task11
            int aa = 3;
            // make it bigger by 10
            aa = aa * 10;
            Console.WriteLine(aa);


            int bb = 100;
            // make it smaller by 7
            bb = bb - 7;
            Console.WriteLine(bb);

            int c = 44;
            // please double c's value
            c = c * 2;
            Console.WriteLine(c);

            int d = 125;
            // please divide by 5 d's value
            d = d / 5;
            Console.WriteLine(d);

            int e = 8;
            // please cube of e's value
            Console.WriteLine(Math.Pow(e, 3));

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)

            if (f1 > f2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)

            if ((g2 * 2) > g1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            //int h = (int)Convert.ToInt64(1357988018575474);
            //// tell if 11 is a divisor of h (print as a boolean)
            //decimal hdivided;
            //h = h / 11;
            //Console.WriteLine(h);

            long h = 1357988018575474;
            // tell if 11 is a divisor of h (print as a boolean)
            decimal hdivided;
            string check;
            hdivided = decimal.Divide(h, 11);
            check = hdivided.ToString();

            if (check.ToLower().Contains('.'))
            {

            }
            else
            {
                Console.WriteLine(true);
            }

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)
            if ((i1 > Math.Pow(i2, 2)) && (i1 < Math.Pow(i2, 3)))
            {
                Console.WriteLine(true);
            }

            int j = 1521;
            // tell if j is divisible by 3 or 5 (print as a boolean)

            if (j % 3 == 0)
            {
                Console.WriteLine(true);

            }
            else if (j % 5 == 0)
            {
                Console.WriteLine(true);
            }

            //task12
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables above

            int remaining;
            int elapsed;
            int secondsD = 86400;

            elapsed = (currentHours * 3600 + currentMinutes * 60 + currentSeconds);
            remaining = secondsD - elapsed;
            Console.WriteLine(remaining);
            Console.WriteLine();

            //task13
            // Modify this program to greet the User instead of the World!
            // The program should ask for the name of the User
            string user;

            Console.WriteLine("Who are you?");
            user = Console.ReadLine();
            Console.WriteLine("Hello " + user + "!");
            Console.WriteLine();

            //task14
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
            double miles;

            try
            {
                Console.WriteLine("How far you?");
                miles = double.Parse(Console.ReadLine());
                Console.WriteLine("Thats about " + Math.Round(miles * 1.609344, 0) + "km. We use metric system here!");
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Ooops! Not a number..");
            }
            //task15
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            int chickens;
            int pigs;

            Console.WriteLine("How many chickens do you have?");
            chickens = int.Parse(Console.ReadLine());
            Console.WriteLine("And how many pigs do you have?");
            pigs = int.Parse(Console.ReadLine());
            Console.WriteLine("That should be " + ((chickens * 2) + (pigs * 4)) + " legs together.");
            Console.WriteLine();

            //task16
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            int fnum1;
            int fnum2;
            int fnum3;
            int fnum4;
            int fnum5;

            Console.WriteLine("Now tell us your favourite numbers.");
            fnum1 = int.Parse(Console.ReadLine());
            fnum2 = int.Parse(Console.ReadLine());
            fnum3 = int.Parse(Console.ReadLine());
            fnum4 = int.Parse(Console.ReadLine());
            fnum5 = int.Parse(Console.ReadLine());

            int[] array1 = { fnum1, fnum2, fnum3, fnum4, fnum5 };

            Console.WriteLine("Thank you, thats enough." + "The sum is: " + array1.Sum() + " The average values is: " + array1.Average());

            //task17
            // Write a program that reads a number from the standard input,
            // then prints "Odd" if the number is odd, or "Even" if it is even.
            int oddEvenInput;
            int oddEven;

            Console.WriteLine("What is your number?");
            oddEvenInput = int.Parse(Console.ReadLine());

            if (oddEvenInput == 0)
            {
                oddEven = 0;
            }
            else if (oddEvenInput % 2 != 0)
            {
                oddEven = 1;
            }
            else
            {
                oddEven = 2;
            }

            switch (oddEven)
            {
                case 0:
                    Console.WriteLine("It is zero.");
                    break;
                case 1:
                    Console.WriteLine("It is odd number.");
                    break;
                case 2:
                    Console.WriteLine("It is even number.");
                    break;
            }

            //task18
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
            int anothernum;

            Console.WriteLine("Give us another number.");
            anothernum = int.Parse(Console.ReadLine());

            if (anothernum <= 0)
            {
                Console.WriteLine("Not enough.");
            }
            else if (anothernum == 1)
            {
                Console.WriteLine("One.");
            }
            else if (anothernum == 2)
            {
                Console.WriteLine("Two.");
            }
            else
            {
                Console.WriteLine("A lot.");
            }

            //task19
            // Write a program that asks for two numbers and prints the bigger one
            int bsnum1;
            int bsnum2;

            Console.WriteLine("Another two numbers please");
            bsnum1 = int.Parse(Console.ReadLine());
            bsnum2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The bigger of these two is: " + Math.Max(bsnum1, bsnum2));

            //task20
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second represents the number of boys
            int partyg;
            int partyb;

            Console.WriteLine("Lets look into parties..");
            Console.WriteLine("How many girls are comming?");
            partyg = int.Parse(Console.ReadLine());
            Console.WriteLine("How many boys are comming?");
            partyb = int.Parse(Console.ReadLine());

            // If the the number of girls and boys are equal and 20 or more people are coming to the party
            // it should print: The party is excellent!
            if (partyg == 0)
            {
                Console.WriteLine("Sausage party");
            }
            else if ((partyg == partyb) && ((partyg + partyb) >= 20))
            {
                Console.WriteLine("The party is excellent!");
            }
            else if ((partyg + partyb) >= 20)
            {
                Console.WriteLine("Quite a cool party!");
            }
            else if ((partyg + partyb) < 20)
            {
                Console.WriteLine("Average party...");
            }
            // If there are 20 or more people coming to the party but the girl - boy ratio is not 1-1
            // it should print: Quite a cool party!
            // If there are less people coming than 20
            // it should print: Average party...
            //
            // If no girls are coming, regardless the count of the people
            // it should print: Sausage party

            //task21
            double a21 = 24;
            int output1 = 0;
            // if a is even increment output1 by one

            if (a21 % 2 == 0)
            {
                output1++;
                Console.WriteLine(output1);

            }

            int b21 = 13;
            string output2 = "";
            // if b is between 10 and 20 set output2 to "Sweet!"
            // if less than 10 set output2 to "Less!",
            // if more than 20 set output2 to "More!"

            if ((b21 >= 10) && (b21 <= 20))
            {
                output2 = "Sweet!";
            }
            else if (b21 < 10)
            {
                output2 = "Less!";
            }
            else
            {
                output2 = "More!";
            }

            Console.WriteLine(output2);

            int c21 = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            if ((credits >= 50) && (!isBonus))
            {
                c21 = c21 - 2;
            }
            else if ((credits <= 50) && (!isBonus))
            {
                c21 = c21 - 1;
            }

            Console.WriteLine(c21);

            int d21 = 8;
            int time = 120;
            string output3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set output3 to "check"
            // if time is more than 200
            // set output3 to "Time output"
            // otherwise set output3 to "Run Forest Run!"

            if ((d21 % 4 == 0) && (time <= 200))
            {
                output3 = "check";
            }
            else if (time > 200)
            {
                output3 = "time output";
            }
            else
                output3 = "Run Forest Run!";

            Console.WriteLine(output3);

            //task22
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.

            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please provide the first number:");

            // Get the first number:
            double number1c;
            number1c = double.Parse(Console.ReadLine());


            Console.WriteLine("Please provide the second number:");

            // Get the second number:
            double number2c;
            number2c = double.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the operation (add, subtract, multiply or divide):");

            // Get the operation from standard input:
            string operation;
            operation = Console.ReadLine();

            double result = 0.0;

            switch (operation)
            {
                case ("+"):
                case ("add"):
                    result = number1c + number2c;
                    break;
                case ("-"):
                case ("substract"):
                    result = number1c - number2c;
                    break;
                case ("*"):
                case ("multiply"):
                    result = number1c * number2c;
                    break;
                case ("/"):
                case ("divide"):
                    result = number1c / number2c;
                    break;
            }

            //// use the `switch` statement and the corresponding calculation
            //// store the result of the calculation in the `result` variable


            //Console.WriteLine("The result of our wonderous calculator is: " + result);
            //Console.WriteLine();
            ////task23
            //// Create a program that writes this line 100 times:
            //// "I won't cheat on the exam!"
            int maxt = 100;
            for (int i = 0; i <= maxt; i++)
            {
                Console.WriteLine("I wont cheat on exams!");
            }

            ////task24
            //// Create a program that prints all the even numbers between 0 and 500
            int max = 500;
            for (int i = 2; i <= max; i += 2)
            {
                Console.WriteLine(i);
            }

            ////task25
            //// Create a program that asks for a number and prints the multiplication table with that number
            ////
            //// Example:
            //// The number 15 should print:
            ////
            //// 1 * 15 = 15
            //// 2 * 15 = 30
            //// 3 * 15 = 45
            //// 4 * 15 = 60
            //// 5 * 15 = 75
            //// 6 * 15 = 90
            //// 7 * 15 = 105
            //// 8 * 15 = 120
            //// 9 * 15 = 135
            //// 10 * 15 = 150

            int inputMultiplier;
            int maxMulti = 10;

            Console.WriteLine("Please provide input multiplier.");
            inputMultiplier = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " * " + inputMultiplier + " = " + i * inputMultiplier);
            }

            //task26
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"

            int twoNumbers1;
            int twoNumbers2;

            Console.WriteLine("Please provide first number.");
            twoNumbers1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide second number.");
            twoNumbers2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (twoNumbers1 > twoNumbers2)
            {
                Console.WriteLine("The second number should be bigger.");
            }
            else
            {
                for (int i = twoNumbers1; i <= twoNumbers2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            //Console.WriteLine();
            //// If it is bigger it should count from the first number to the second by one
            ////
            //// example:



            //// first number: 3, second number: 6, should print:
            ////
            //// 3
            //// 4
            //// 5

            ////task27
            //// Write a program that prints the numbers from 1 to 100
            //// but for multiples of three print “Fizz” instead of the number
            //// and for the multiples of five print “Buzz”
            //// For numbers which are multiples of both three and five print “FizzBuzz”

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            //Console.WriteLine();
            ////task28
            //// Write a program that reads a number from the standard input, then draws a
            //// triangle like this:
            ////
            //// *
            //// **
            //// ***
            //// ****
            ////
            //// The triangle should have as many lines as the number was
            int triangle;

            Console.WriteLine("Lets draw the triangle.");
            triangle = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= triangle; i++)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat(triangle, i)));
            }
            Console.WriteLine();

            //task29
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            
            
            //    *
            //   ***
            //  *****
            // *******

            // The pyramid should have as many lines as the number was

            int pyramid;

            Console.WriteLine("Lets draw the pyramid.");
            pyramid = int.Parse(Console.ReadLine());

            int emptyChLenP = pyramid + 1;

            Console.WriteLine();
            //Console.WriteLine(String.Concat(pyramid));

            for (int i = 0; i < pyramid; i++)
            {
                Console.WriteLine(String.Concat
                    (String.Concat(
                    (String.Concat(Enumerable.Repeat("*", emptyChLenP - i - 1))),
                    (String.Concat(Enumerable.Repeat(pyramid, i * 2 + 1))),
                    (String.Concat(Enumerable.Repeat("*", emptyChLenP - i - 1))))));
            }
            
            //task30
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            int diamond;

            Console.WriteLine("Lets draw the diamond.");
            diamond = int.Parse(Console.ReadLine());

            int diamondLineCount = diamond * 2 - 1;
            int emptyChLenD = diamond + 1;

            int dCountH = 0;
            int dCountB;
     

            Console.WriteLine();
            //Console.WriteLine(String.Concat(diamond * diamond.ToString().Length));

            for (int i = 0; i < diamondLineCount; i++)
            {

                if (i < diamond)
                {
                    dCountH = i * 2 + 1;
                    Console.WriteLine(String.Concat
                        (String.Concat(
                        (String.Concat(Enumerable.Repeat("*", emptyChLenD - i - 1))),
                        (String.Concat(Enumerable.Repeat(diamond, dCountH))),
                        (String.Concat(Enumerable.Repeat("*", emptyChLenD - i - 1))))));

                }
                else
                {

                    dCountH = dCountH - 2;

                    Console.WriteLine(String.Concat
                       (String.Concat(
                       (String.Concat(Enumerable.Repeat("*", i - emptyChLenD + 3))),
                       (String.Concat(Enumerable.Repeat(diamond, dCountH))),
                       (String.Concat(Enumerable.Repeat("*", i - emptyChLenD + 3))))));
                }


            }
            //task31
            
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
            // %%%%%%
            //
            // The square should have as many lines as the number was
            int square;

            Console.WriteLine("Lets draw the square.");
            square = int.Parse(Console.ReadLine());

            Console.WriteLine();
            //Console.WriteLine(String.Concat(pyramid));

            for (int i = 1; i <= square; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(String.Concat(Enumerable.Repeat(square, square)));
                }
                else if ((i < square) && (i > 0))
                {


                    Console.WriteLine(String.Concat
                       (String.Concat(square,
                       (String.Concat(Enumerable.Repeat(" ", square - 2))),
                       (String.Concat(square)))));


                }
                else //if (i == diagonal)
                {
                    Console.WriteLine(String.Concat(Enumerable.Repeat(square, square)));
                }
            }

            //task32

            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number wa
            int diagonal;

            Console.WriteLine("Lets draw the diagonal.");
            diagonal = int.Parse(Console.ReadLine());

            Console.WriteLine();
            //Console.WriteLine(String.Concat(pyramid));

            for (int i = 1; i <= diagonal; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine(String.Concat(Enumerable.Repeat(diagonal, diagonal)));
                }
                else if ((i < diagonal) && (i > 0))
                {


                    Console.WriteLine(String.Concat
                       (String.Concat(diagonal,
                       (String.Concat(Enumerable.Repeat(" ", i - 1))),
                       (String.Concat(diagonal)),
                       (String.Concat(Enumerable.Repeat(" ", diagonal - i - 1))), diagonal)));


                }
                else //if (i == diagonal)
                {
                    Console.WriteLine(String.Concat(Enumerable.Repeat(diagonal, diagonal)));
                }
            }

            //task33
            // Write a program that stores a number and the user has to figure it out
            // The user can input guesses
            // After each guess the program would tell one of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int rightN = 6;
            int mysteriousN;
            bool resultN = false;

            Console.WriteLine("Lets guess numbers.");

            do
            {
                mysteriousN = int.Parse(Console.ReadLine());

                if (mysteriousN < rightN)
                {
                    Console.WriteLine("The right number is higher");
                    Console.WriteLine("Try again.");
                    resultN = false;
                }
                else if (mysteriousN > rightN)
                {
                    Console.WriteLine("The right number is lower");
                    Console.WriteLine("Try again.");
                    resultN = false;
                } else 
                    {
                    Console.WriteLine("You got it!");
                    resultN = true;
                }

            } while (!resultN);

           
            //task34
            // Write a program that asks for a number
            // It would ask this many times to enter an integer
            // If all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            int timesN;
            int numValue;

            Console.WriteLine("How many numbers will be used?");
            timesN = int.Parse(Console.ReadLine());

            List<int> NumberList = new List<int>();
           

           for (int i = 0; i < timesN; i++)
            {
                Console.WriteLine("Enter a number.");
                timesN = int.Parse(Console.ReadLine());
                NumberList.Add(timesN);
            }

            Console.WriteLine();
            Console.WriteLine("The sum is: "+NumberList.Sum());
            Console.WriteLine("Their average value is: "+NumberList.Average());
            Console.WriteLine();
            //task35
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %

            bool answer;
            Console.WriteLine("Do you want to generate chess table (true/false)?");
            answer = bool.Parse(Console.ReadLine());

            if(answer)
            {
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine("% % % % ");
                    Console.WriteLine(" % % % %");
                }
            }
             
            //task36
            //  Create a function that takes two strings as a parameter
            //  Returns the starting index where the second one is starting in the first one
            //  Returns `-1` if the second string is not in the first one

            //  Example:

            //  should print: `17`
            // Console.WriteLine(Substr("this is what I'm searching in", "searching"));

            //  should print: `-1`
            // Console.WriteLine(Substr("this is what I'm searching in", "not"));

            string subString;
            string sample;

            Console.WriteLine("What text do you want to search?");
            sample = Console.ReadLine();
            Console.WriteLine("What text do you search for?");
            subString = Console.ReadLine();

            if (sample.Contains(subString))
            {
                Console.WriteLine("Searched string starts at position ");
            } else
            {
                Console.WriteLine("Not there.");
            }

            

            

        }
    }
}
