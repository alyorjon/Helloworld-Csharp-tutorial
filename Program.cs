using System;
using System.Collections;
using System.Net.Mime;
using HELLOWORLD;
class Program
{
    static void Main()
    {
        PrintToConsole();
        VariablesAndDataTypes();
        MathOperators();
        ComparisonOperators();
        LogicalOperators();
        ConditionalStatetments();
        LoopMethods();
        

    }
    

    
    
    static void LoopMethods()
    {
        for (int i = 0; i < 50000; i++)
        {
            Console.WriteLine(i + 1);
        }
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine(count + 4);
            count++;
        }
        count = 0;
        do
        {
            Console.WriteLine("Do -while count:" + count);
            count++;
        }
        while (count < 10);

        int[] numbers = { 1, 2, 3, 45, 5, 6 };
        foreach (int i in numbers)
        {
            Console.WriteLine("Number in array is: " + i);
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Using standard for loop-numbers is : " + numbers[i]);
        }
    }
    static void PrintToConsole()
    {
        Console.WriteLine("Welcome to crash course");

    }

    static void ConditionalStatetments()
    {
        int age = 3;
        if (age < 18)
        {
            Console.WriteLine("You are a minor");
        }
        else if (age >= 18 && age < 60)
        {
            Console.WriteLine("Your age is an adult");
        }
        else
        {
            Console.WriteLine("You are an older");

        }

        int day = 3;
        string dayName;
        switch (day)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thuersday";
                break;
            default:
                dayName = "Weekend";
                break;

        }
        Console.WriteLine("today is "+dayName );

    }   
    static void LogicalOperators()
    {
        bool x = true;
        bool y = false;
        bool andResult = (x && y);
        bool orResult = (x || y);
        bool notResult = (x || !y);
        Console.WriteLine(andResult);
        Console.WriteLine(orResult);
        Console.WriteLine(notResult);
        bool notResult2 = !x;
        Console.WriteLine(notResult2);
    }
    static void ComparisonOperators()
    {
        int a = 10;
        int b = 5;
        bool isEqual = (a == b);
        Console.WriteLine(isEqual);
        bool isNotEqual = (a != b);
        Console.WriteLine(isNotEqual);
        bool isGreater = (a > b);
        bool isLess = (a < b);
        bool isGreaterThanOrEqual = (a >= b);
        bool isLessThanOrEqual = (a <= b);
        Console.WriteLine(isGreater);
        Console.WriteLine(isLess);
        Console.WriteLine(isGreaterThanOrEqual);
        Console.WriteLine(isLessThanOrEqual);
    }
    static void MathOperators()
    {
        int num1 = 10;
        int num2 = 5;
        int addition = num1 + num2;
        Console.WriteLine(addition);
        int subtraction = num1 - num2;
        Console.WriteLine(subtraction);

        int num3 = 0;
        try
        {
            int devision1 = num2 / num3;
            Console.WriteLine(devision1);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Excaption :{ex.Message}");
        }
    }
    static void VariablesAndDataTypes()
    {
        int age = 40;
        Console.WriteLine(age);
        float temperature = 20.4f;
        Console.WriteLine(temperature);
        double interest = 5.53;
        Console.WriteLine("interest:" + interest);

        decimal stockPrice = 4.535353M;
        Console.WriteLine(stockPrice);

        char grade = 'A';
        Console.WriteLine(grade);
        string name = "Alyor";
        Console.WriteLine(name);
        Console.WriteLine($"My name is {name}.");
        bool isStudent = true;
        int quantity;
        string products;
        quantity = 5;
        products = "Apple";
        Console.WriteLine(quantity);
        Console.WriteLine($"Quantity:{quantity}. Products:{products}");


        const double Pi = 3.14;
        Console.WriteLine(Pi);
    }
}