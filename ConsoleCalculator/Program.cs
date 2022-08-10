using System;
using System.Collections.Generic;
using System.Linq;

//Making a Calculator
class Calculator
{
    double numberOne;
    double numberTwo;

    public Calculator()
    {
        // Get user values that they want to perform an operation on
        Console.WriteLine("Please Enter a number");
        string numberOneValue = Console.ReadLine();

        Console.WriteLine("Please enter an operation like - + * / or %");
        string operationsSymbol = Console.ReadLine();

        Console.WriteLine("Please Enter another number");
        string numberTwoValue = Console.ReadLine();

        //Converting our values to double since it's a string
        double numberOneValueConverted = Convert.ToDouble(numberOneValue);
        double numberTwoValueConverted = Convert.ToDouble(numberTwoValue);


        //Performing the operation on the values
        if (operationsSymbol == "-")
        {
            Console.WriteLine(numberOneValueConverted - numberTwoValueConverted);
        }
        else if (operationsSymbol == "+")
        {
            Console.WriteLine(numberOneValueConverted + numberTwoValueConverted);
        }
        else if (operationsSymbol == "*")
        {
            Console.WriteLine(numberOneValueConverted * numberTwoValueConverted);
        }
        else if (operationsSymbol == "/")
        {
            Console.WriteLine(numberOneValueConverted / numberTwoValueConverted);
        }
        else if (operationsSymbol == "%")
        {
            Console.WriteLine(numberOneValueConverted % numberTwoValueConverted);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calOne = new Calculator();
    }
}
