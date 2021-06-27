using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class CalculatorView
    {
        public void printString(String itemToPrint)
        {
            // Display title as the C# console calculator app.
            Console.WriteLine(itemToPrint);
        }

        public void printOptions()
        {
            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
        }

        public String getChar()
        {
            return (Console.ReadLine());
        }

        public void printResult(double result)
        {
            Console.WriteLine("Your result: {0:0.##}\n", result); 
        }
        
        public void printMessage(String message)
        {
            Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + message);
        }

        public double getDoubleFromUser()  // static method to get a number from the user since we do it a couple of times
        {
            // Ask the user to type the number.
            Console.Write("Type a number, and then press Enter: ");
            // Get the input
            string numInput = Console.ReadLine();
            // See if it is a number
            double cleanNum = 0;
            while (!double.TryParse(numInput, out cleanNum))
            {
                Console.Write("This is not valid input. Please enter a number: ");
                numInput = Console.ReadLine();
            }
            return cleanNum;
        }  // getDoubleFromUser
    }
}
