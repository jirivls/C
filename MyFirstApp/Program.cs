using System;
using System.Diagnostics.SymbolStore;
using System.Runtime.Intrinsics.X86;

namespace GreenFox
{
    class Program
    {
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
            double bmi = Math.Round(massInKg / Math.Pow(heightInM,2));
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
            int a = 3;
            // make it bigger by 10

            Console.WriteLine(a);

            int b = 100;
            // make it smaller by 7

            Console.WriteLine(b);

            int c = 44;
            // please double c's value

            Console.WriteLine(c);

            int d = 125;
            // please divide by 5 d's value

            Console.WriteLine(d);

            int e = 8;
            // please cube of e's value

            Console.WriteLine(e);

            int f1 = 123;
            int f2 = 345;
            // tell if f1 is bigger than f2 (print as a boolean)

            int g1 = 350;
            int g2 = 200;
            // tell if the double of g2 is bigger than g1 (print as a boolean)

            int h = 1357988018575474;
            // tell if 11 is a divisor of h (print as a boolean)

            int i1 = 10;
            int i2 = 3;
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            int j = 1521;
            // tell if j is divisible by 3 or 5 (print as a boolean)
        }
    }
}
