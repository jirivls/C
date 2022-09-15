using System;

public class Program
{
	public Program()
	{


        int twoNumbers1;
        int twoNumbers2;

        Console.WriteLine("Please provide first number.");
        twoNumbers1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please provide first number.");
        twoNumbers2 = int.Parse(Console.ReadLine());

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

    }
}
