using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
// - Create an array variable named `numbers`
//   with the following content: `[4, 5, 6, 7]`
// - Print the third element of `numbers`

/*
Console.WriteLine("How many numbers are there going to be?");
int lenght = int.Parse(Console.ReadLine());
Console.WriteLine();

int[] numbers = new int[lenght];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();

Console.WriteLine(numbers.Sum());
Console.WriteLine(numbers.Average());


Console.WriteLine("How many users are there?");
int lenght = int.Parse(Console.ReadLine());
Console.WriteLine();

string[] users = new string[lenght];

for (int i = 0; i < users.Length; i++)
{
    users[i] = (Console.ReadLine());
}

for (int i = 0; i < users.Length; i++)
{
    Console.WriteLine($"Hello, {users[i]}");
}



int[,] twoDimensionalArray = new int[5, 7];

twoDimensionalArray[0,0] = 3;

for(int i = 0; i < twoDimensionalArray.GetLength(0); i++)
{
    for (int j = 0; j < twoDimensionalArray.GetLength(1); j++) 
    {
        Console.Write(twoDimensionalArray[i,j]);
    }
    Console.WriteLine();
}




int mathFn(int number1, int number2)
{
    int result = number1 + number2;
    return result;
}

Console.WriteLine(mathFn(2,4));


int Sum(int[] number)
{
    int sum = 0;    
    for(int i = 0; i < number.Length; i++)
    {
        sum += number[i];
    }
    return sum;
}

int[] ints = { 10, 15, 20, 30 };
Console.WriteLine(Sum(ints));



*/
//task1

// - Create an array variable named `numbers`
//   with the following content: `[4, 5, 6, 7]`
// - Print the third element of `numbers`
Console.ReadLine();
int[] number = {4,5,6,7};

Console.WriteLine(number[0]);

//task2

// - Create an array variable named `firstArrayOfNumbers`
//   with the following content: `[1, 2, 3]`
// - Create an array variable named `secondArrayOfNumbers`
//   with the following content: `[4, 5]`
// - Print "secondArrayOfNumbers is longer" if 
//   `secondArrayOfNumbers` has more elements than
//   `firstArrayOfNumbers`
// - Otherwise print: "firstArrayOfNumbers is the longer one"
Console.ReadLine();
int[] firstArrayOfNumbers = { 1, 2, 3 };
int[] secondArrayOfNumbers = { 4, 5 };

if (firstArrayOfNumbers.Length > secondArrayOfNumbers.Length)
{
    Console.WriteLine("firstArrayOfNumbers is the longer one");
}
else
{
    Console.WriteLine("secondArrayOfNumbers is the longer one");
}


//task3
// - Create an array variable named `numbers`
//   with the following content: `[54, 23, 66, 12]`
// - Print the sum of the second and the third element
Console.ReadLine();
int[] numbers = { 54, 23, 66, 12 };

Console.WriteLine(numbers[1] + numbers[2]);


//task4
// - Create an array variable named `numbers`
//   with the following content: `[1, 2, 3, 8, 5, 6]`
// - Change the value of the fourth element (8) to 4
// - Print the fourth element
Console.ReadLine();
int[] numbers4 = { 1, 2, 3, 8, 5, 6 };

numbers[3] = 4;
Console.WriteLine(numbers[3]);


//task5
//- Create an array variable named `numbers`
//  with the following content: `[1, 2, 3, 4, 5]`
//- Increment the third element
//- Print the third element
Console.ReadLine();
int[] numbers5 = { 1, 2, 3, 4, 5 };
numbers[2]++;
Console.WriteLine(numbers[2]);


//task6
// - Create an array variable named `numbers`
//   with the following content: `[4, 5, 6, 7]`
// - Print all the elements of `numbers`
Console.ReadLine();
int[] numbers6 = { 4, 5, 6, 7 };

for(int i66 = 0; i66 < numbers.Length;  i66++)
{
    Console.WriteLine(numbers[i66]);
}


//task7
// - Create a two dimensional array dynamically with the following content.
//   Note that a two dimensional array is often called matrix if every
//   internal array has the same length.
//   Use a loop!
//
//   1 0 0 0
//   0 1 0 0
//   0 0 1 0
//   0 0 0 1
//
//   Its length should depend on a variable
//  
// - Print this two dimensional array to the output

Console.WriteLine("How many numbers shall we use for matrix task?");
int len = int.Parse(Console.ReadLine());

int[,] arrayRow = new int[len,len];
arrayRow[1, 0] = 1;

for (int i7 = 0; i7 < arrayRow.GetLength(0); i7++)
{
    for (int j = 0; j < arrayRow.GetLength(1); j++)
    {                    
        arrayRow[i7,j] = 0;
        arrayRow[j,i7] = 1;
        Console.Write(arrayRow[i7, j]);
    }
    Console.WriteLine();

}


//task8
// - Create an array variable named `numbers`
//   with the following content: `[3, 4, 5, 6, 7]`
// - Double all the values in the array
Console.ReadLine();
int[] numbers8 = { 3, 4, 5, 6, 7 };

for (int i8 = 0; i8 < numbers.Length; i8++)
{
    numbers[i8] = numbers[i8]*2;
    Console.WriteLine(numbers[i8]);
}


//task9
// - Create a two dimensional array
//   which can contain the different shades of specified colors
// - In `colors[0]` store the shades of green:
//   `"lime", "forest green", "olive", "pale green", "spring green"`
// - In `colors[1]` store the shades of red:
//   `"orange red", "red", "tomato"`
// - In `colors[2]` store the shades of pink:
//   `"orchid", "violet", "pink", "hot pink"`
Console.ReadLine();

string[,] colors = new string[,]
    { 
        { "lime", "forest green", "olive","pale green", "spring green" },
        {"orange red", "red", "tomato", "","" },
        {"orchid", "violet", "pink", "hot pink","" } 
    };


for (int i8 = 0; i8 < colors.GetLength(0); i8++)
{
    for (int j = 0; j <= colors.GetLength(0) + 1; j++)
    {
        Console.Write((colors[i8, j])+ " ");
    }
    Console.WriteLine();
 }



//task10
// - Create an array variable named `animals`
//   with the following content:
//   `["koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill",
//     "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn"]`
//
// - Add all elements an `"a"` at the end
Console.ReadLine();

string[] animals = {"koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill",
                    "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn"};

foreach (string animal in animals)
{
    Console.WriteLine(String.Concat(animal,"a"));
}


//task11
// - Create an array variable named `orders`
//   with the following content: `["first", "second", "third"]`
// - Swap the first and the third element of `orders`
Console.ReadLine();
string[] orders = { "first", "second", "third" };
(orders[0], orders[2]) = (orders[2], orders[1]);

Console.WriteLine($"1st: {orders[0]}, 2nd {orders[1]}, 3rd {orders[2]}");


//task12
// - Create an array variable named `numbers`
//   with the following content: `[3, 4, 5, 6, 7]`
// - Print the sum of the elements of `numbers`
Console.ReadLine();

int[] numbers12 = { 3, 4, 5, 6, 7 };
Console.WriteLine(numbers.Sum());


//task13
// - Create an array variable named `numbers`
//   with the following content: `[3, 4, 5, 6, 7]`
// - Reverse the order of the elements of `numbers`
// - Print the elements of the reversed `numbers`
Console.ReadLine();
int[] numbers13 = { 3, 4, 5, 6, 7 };
(numbers13[4], numbers13[3], numbers13[2], numbers13[1], numbers13[0]) = (numbers13[0], numbers13[1], numbers13[2], numbers13[3], numbers13[4]);
Console.WriteLine($"The reversed order is: {numbers13[0]}, {numbers13[1]}, {numbers13[2]}, {numbers13[3]}, {numbers13[4]}");


//task14
// - Create an integer variable named `baseNumber` and assign the value `123` to it
// - Create a function called `DoubleNumber()` that doubles it's input parameter
//   and returns the doubled value
// - Print the result of `DoubleNumber(baseNumber)`
Console.ReadLine();

int baseNumber = 123;

int doubleNumber(int baseNumber)
{
    int result = baseNumber * baseNumber;
    return result;
}

Console.WriteLine(doubleNumber(2));


//task15
// - Create a string variable named `al` and assign the value `Green Fox` to it
// - Create a function called `Greet()` that greets its input parameter
//     - It prints a greeting message e.g. `Greetings dear Green Fox`
// - Greet `al`

string al = "Green fox";

void Greet()
{
    Console.WriteLine($"Greeting dear {al}");

}

Greet();



//task16
// - Create a string variable named `typo` and assign the value `Chinchill` to it
// - Write a function called `AppendA()` that gets a string as an input,
//   appends an 'a' character to its end and returns with a string
// - Print the result of `AppendA(typo)`
Console.ReadLine();

string typo = "Chinchill";

void AppednA(string typo)
{
    Console.WriteLine(String.Concat(typo,"a"));
}

AppednA(typo);


//task17
// Write a function called `sum()` that returns the sum of numbers from zero to the given parameter
Console.WriteLine("to what number should we add?");
int num1 = int.Parse(Console.ReadLine());

int sum(int num1)
{
    int result = num1 * (num1 + 1) / 2;
    return result;
}

Console.WriteLine(sum(num1));



//task18
// - Create a function called `calculateFactorial()`
//   that returns the factorial of its input

Console.WriteLine("Lets calculate the factorial of number...?");
int num2 = int.Parse(Console.ReadLine());
int result = num2;

int calulateFacotiral(int num2)
{
    for (int i = 1; i < num2; i++)
    {
       result = result * (num2 - i);                   
    }
    return result;
}

Console.WriteLine(calulateFacotiral(num2));


//task19
//  Create a function that takes a number and an array of integers as parameters
//  It returns the indices of the integers of the array which contain the given number
//  or returns an empty array (if the number is not part of any of the integers in the array)

//  Example:
//Console.WriteLine(FindMatchingIndexes(1, new int[] { 1, 11, 34, 52, 61 }));
////  should print: `[0, 1, 4]`
//Console.WriteLine(FindMatchingIndexes(9, new int[] { 1, 11, 34, 52, 61 }));
//  should print: '[]'

Console.WriteLine("Finding position of int in given array..");
int num3 = int.Parse(Console.ReadLine());

int[] arrayNum = { 1, 11, 34, 52, 61 };
string result19 = null;
//bool result = arrayNum[2].ToString().Contains(num3.ToString());

//Console.WriteLine(result);

string numIndex(int num2)
{
    for (int i = 0; i < arrayNum.Length; i++)
    {
        if (arrayNum[i].ToString().Contains(num3.ToString()))
        {
            result19 = result19 + Convert.ToString(i) + ",";
        }
    }

    if (String.IsNullOrEmpty(result19))
    {
        result19 = "[]";
    }
    else
    {
        result19 = result19.Remove(result19.Length - 1);
        result19 = String.Concat("[", result19, "]");
    }           
    return result19;
}

Console.WriteLine(numIndex(num3));



//task20
//  Create a method that takes an array of integers as a parameter
//  and returns an array of integers where every integer is unique (occurs only once)

//  Example
//Console.WriteLine(FindUniqueItems(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
//  should print: `[1, 11, 34, 52, 61]`

    Console.WriteLine("In how many numbers are we going to search?");
    int lenght = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Thank you, now provide the numbers please..");

    int[] integerList = new int[lenght];

    for (int i20 = 0; i20 < integerList.Length; i20++)
    {
        integerList[i20] = int.Parse(Console.ReadLine());    
    }

    int[] newList = integerList.Distinct().ToArray();
    Console.WriteLine("Here are your unique values..");
    foreach (int integer in newList)
    {
            Console.WriteLine(integer);
    }


//task21
// is anagram?

string word1 = "";
    string word2 = "";
    bool result21 = true;

    Console.WriteLine("What are your words?");
    word1 = (Console.ReadLine());
    word2 = (Console.ReadLine());

    int lenWord1 = word1.Length;
    int lenWord2 = word2.Length;

    char[] word1Arr = word1.ToCharArray(0,lenWord1);
    char[] word2Arr = word2.ToCharArray(0, lenWord2);

//Console.WriteLine(word1Arr.Distinct().Count());
//Console.WriteLine(word2Arr.Distinct().Count());



if (lenWord1 == lenWord2)
        {
        if (String.Concat(word1.OrderBy(c => c)) == String.Concat(word2.OrderBy(c => c)))
        {

            for (int i21 = 0; i21 < lenWord1; i21++)
            {
                if (!word1Arr.Contains(word2Arr[i21]))
                {
                    result21 = false;
                }
            }

            Console.WriteLine(result);
        } else
        {
                Console.Write("Not the same");
                result21 = false;
    }
        } else
    
        {
         Console.Write("They arent even the same lenght..");
        result21 = false;
}


//task22

//Console.WriteLine(String.Concat(palindrome, Reverse(palindrome));



string wordIn="";
string wordOut = "";

Console.WriteLine("Provide a word - palindrome");
wordIn = Console.ReadLine();
wordOut = wordIn;

int i;
int len22 = wordIn.Length - 1;

string createPalindrome(string palindrome)
{
    for (i = len; i >= 0; i--)
    {

        wordOut = wordOut + wordIn[i];


    }
    return wordOut;
}

Console.WriteLine(createPalindrome(wordOut));

//task23


    string wordOutA = "";
    //string wordOutB = "";
    string wordA = "";
    string wordOfArrayB = "";
    string result23 = "";
    string palindrome = "";


    Console.WriteLine("Provide a word - palindrome search");
    Console.WriteLine("---------------------------------");

    palindrome = Console.ReadLine();
    wordOutA = palindrome;

string searchPalindrome(string palindrome)
{

    int i, i1, i2, i3, i4, i5, i6;
    int len2 = palindrome.Length - 3;

    List<string> listA = new List<string>();
    List<string> listB = new List<string>();

    //for (i1 = len2; i1 >= 0; i1--)
    //{
    //    wordOutB = wordOutB + palindrome[i1];

    //}
    int test = 3;

    for (i2 = 0; i2 < len2; i2++)
    {

        for (i3 = 0; i3 < len2; i3++)
        {
            try
            {

                wordA = wordOutA.Substring(i3, i2 + 3);
                listA.Add(wordA);
                //Console.WriteLine(listA.Last());

            }
            catch { }

        }
    }


        //    listA = palindrome.Split(' ').ToList();

        //foreach (var l in listA)
        //{
        //    Console.WriteLine(l);
        //}

        string[] word1Arr = listA.ToArray();

    for (i4 = 0; i4 < word1Arr.Length; i4++)
    {

        wordOfArrayB = "";
        char[] charsOfArrayW = word1Arr[i4].ToCharArray();

        try
        {
            for (i5 = 1; i5 <= charsOfArrayW.Length; i5++)
            {
                wordOfArrayB = wordOfArrayB + charsOfArrayW[charsOfArrayW.Length - i5];

            }

        }
        catch { }
        listB.Add(wordOfArrayB);
    }



    for (i6 = 0; i6 < listA.Count(); i6++)
    {

        if (listA[i6].ToString() == listB[i6].ToString())
        {
            //Console.WriteLine(listA[i6].ToString());
            result23 = result23 + '"' + listA[i6].ToString() + '"' + ",";
        }
    }

    if (result23 != "")
    {
        result23 = String.Concat(("["), (result23.Remove(result23.Length - 1)), ("]"));
    }


    return result23;

}

Console.WriteLine(searchPalindrome(palindrome));



//task24
//  Create a function that takes an array of numbers as parameter
//  and returns an array where the elements are sorted in ascending numerical order
//  When you are done, add a second boolean parameter to the function
//  If it is `true` sort the array descending, otherwise ascending

//  Example:
//Console.WriteLine(Bubble(new int[] { 34, 12, 24, 9, 5 }));
////  should print [5, 9, 12, 24, 34]
//Console.WriteLine(AdvancedBubble(new int[] { 34, 12, 24, 9, 5 }, true));
////  should print [34, 24, 12, 9, 5]
///

Console.WriteLine("How many number will be used?");
int numberOfInt = int.Parse(Console.ReadLine());
Console.WriteLine("Provide the numbers..");
int[] arrayIn = new int[numberOfInt];
int[] sortedArray = new int[numberOfInt];
string resultString = "";

for (int i24 = 0; i24 < arrayIn.Length; i24++)
{
    arrayIn[i24] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Type true/false for ascending order.");
bool orderOfNum = bool.Parse(Console.ReadLine());

Console.WriteLine("Here they are sorted..");

int[] sortArray(int[] sortedArray, bool orderOfNum)
{

    Array.Sort(arrayIn);
    
    if (!orderOfNum)
    {
        Array.Reverse(arrayIn);
    }

    sortedArray = arrayIn;
    return sortedArray;
}


foreach (int res in sortArray(sortedArray,orderOfNum))
{

    Console.Write(res + ",");
   
}
