using System;
using System.Reflection.Metadata;

namespace Assignment_Session03
{
    internal class Program
    {
        class Person
        {
            public string Name;
        }
        static void Main(string[] args)
        {
            #region Q1 - Write a program that allows the user to enter a number then print it.
            //Console.Write("Please enter a number: ");
            //string userInput = Console.ReadLine();
            //int number = Convert.ToInt32(userInput);
            //Console.WriteLine("You entered: " + number);
            #endregion

            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //string userInput = "zyx";
            //int number = Convert.ToInt32(userInput);
            //Console.WriteLine("Converted number: " + number);
            //he program will throw a FormatException because the string contains non-numeric characters, and Convert.ToInt32() cannot convert it to an integer.
            #endregion

            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //double num1 = 10.5;
            //double num2 = 2.5;
            //double result = num1 + num2;
            //Console.WriteLine("The result of the addition is: " + result);
            // The program will successfully perform the addition of two floating-point numbers (10.5 + 2.5) and output 13.0
            #endregion

            #region Q4 - Write C# program that Extract a substring from a given string.
            //string str = "Hello, World!";
            //string substring = str.Substring(7, 5);
            //Console.WriteLine("Extracted substring: " + substring);

            #endregion

            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int num1 = 10;
            //int num2 = num1;
            //num1 = 20;

            //Console.WriteLine("num1: " + num1);
            //Console.WriteLine("num2: " + num2);
            // modifying the value of num1 does not affect num2 because value types store copies of data, not references.
            #endregion

            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            //Person person1 = new Person();
            //person1.Name = "Gouda";

            //Person person2 = person1;
            //person2.Name = "Mohamed";

            //Console.WriteLine("person1 Name: " + person1.Name);
            //Console.WriteLine("person2 Name: " + person2.Name);
            //This demonstrates that reference types store references to objects, not copies. Modifying the object through one variable affects all variables referencing that object.
            #endregion

            #region Q7 - Write C# program that take two string variables and print them as one variable 

            //string str1 = "Hello, ";
            //string str2 = "World!";

            //string combined = str1 + str2;
            //Console.WriteLine(combined);
            #endregion

            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time
            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.

            //double principal, rate, time, interest;

            //Console.Write("Enter the principal amount: ");
            //principal = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the rate of interest: ");
            //rate = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter the time (in years): ");
            //time = Convert.ToDouble(Console.ReadLine());

            //interest = (principal * rate * time) / 100;

            //Console.WriteLine("The simple interest is: " + interest);
            #endregion

            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            //double weight, height, bmi;

            //Console.Write("Enter your weight (in kilograms): ");
            //weight = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter your height (in meters): ");
            //height = Convert.ToDouble(Console.ReadLine());

            //bmi = weight / (height * height);

            //Console.WriteLine("Your Body Mass Index (BMI) is: " + bmi);

            #endregion

            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.
            ///that below 10 degrees is "Just Cold"
            ///above 30 degrees is "Just Hot"
            ///anything else is "Just Good"
            //double temperature;

            //Console.Write("Enter the temperature: ");
            //temperature = Convert.ToDouble(Console.ReadLine());

            //string result;

            //if (temperature < 10)
            //{
            //    result = "Just Cold";
            //}
            //else if (temperature > 30)
            //{
            //    result = "Just Hot";
            //}
            //else
            //{
            //    result = "Just Good";
            //}

            //Console.WriteLine("The temperature is: " + result);


            #endregion

            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.
            ///Ex:
            ///Today’s date : 20 , 11 , 2001
            ///Today's date : 20 / 11 / 2001
            ///Today's date : 20 – 11 – 2001
            //Console.Write("Enter the day: ");
            //int day = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the month: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the year: ");
            //int year = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Today's date: {day}, {month}, {year}");
            //Console.WriteLine($"Today's date: {day} / {month} / {year}");
            //Console.WriteLine($"Today's date: {day}–{month}–{year}");

            #endregion

            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            ///Example(1)
            ///Input: 12
            ///Output: Yes
            ///Example(2)
            ///Input: 9
            ///Output: No
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            #endregion

            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            ///Example(1)
            ///Input: -5
            ///Output: negative
            ///Example(2)
            ///Input: 10
            ///Output: positive
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}

            #endregion

            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            ///Example(1)
            ///Input: 7,8,5
            ///Output:
            ///max element = 8
            ///min element = 5
            ///Example(2)
            ///Input: 3 6 9
            ///Outputs:
            ///Max element = 9
            ///Min element = 3

            //Console.Write("Enter the first integer: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second integer: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the third integer: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int maxElement = Math.Max(num1, Math.Max(num2, num3));
            //int minElement = Math.Min(num1, Math.Min(num2, num3));

            //Console.WriteLine($"Max element = {maxElement}");
            //Console.WriteLine($"Min element = {minElement}");


            #endregion

            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");
            //}
            #endregion

            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            ///Example(1)
            ///Input: O
            ///Output: vowel
            ///Example(2)
            ///Input: b
            ///Output: Consonant
            //Console.Write("Enter a character: ");
            //char ch = Convert.ToChar(Console.ReadLine().ToLower());

            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}

            #endregion

            #region Q17 - Write a program to input the month number and print the number of days in that month.
            /// Example
            /// Input: Month Number: 1
            /// Output: Days in Month: 31

            Console.Write("Enter the month number (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            int days;

            switch (month)
            {
                case 1: // January
                case 3: // March
                case 5: // May
                case 7: // July
                case 8: // August
                case 10: // October
                case 12: // December
                    days = 31;
                    break;
                case 4: // April
                case 6: // June
                case 9: // September
                case 11: // November
                    days = 30;
                    break;
                case 2: // February
                    Console.Write("Enter the year: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    // Check for leap year
                    days = (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? 29 : 28;
                    break;
                default:
                    Console.WriteLine("Invalid month number.");
                    return;
            }

            Console.WriteLine($"Days in month {month}: {days}");
        
        #endregion

    }
    }
}
