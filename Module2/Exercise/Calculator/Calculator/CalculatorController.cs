using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class CalculatorController
    {

        CalculatorModel myCalc = new CalculatorModel();  // myCalc is the model
        CalculatorView myView = new CalculatorView();    // myView is the view

        bool endApp = false;                   // local variable to flag when to end the application

        public CalculatorController()
        {

            while (!endApp)
            {
                // Display title as the C# console calculator app.
                myView.printString("Console Calculator in C#\r");
                myView.printString("------------------------\n");

                // Get the first valid number from the user
                myView.printString("First number --");
                myCalc.Number1 = myView.getDoubleFromUser();

                // Get the first valid number from the user
                myView.printString("Second number --");
                myCalc.Number2 = myView.getDoubleFromUser();

                myView.printOptions();

                string op = myView.getChar().ToLower();

                try
                {
                    double result = myCalc.DoOperation(op);  // invokes the DoOperation method of the object and passes the operation

                    if (double.IsNaN(result))
                    {
                        myView.printString("This operation can not be performed.\n");
                    }
                    else myView.printResult(result);
                }
                catch (Exception e)
                {
                    myView.printMessage(e.Message);
                }

                myView.printString("------------------------\n");

                // Wait for the user to respond before closing.
                myView.printString("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (myView.getChar() == "n") endApp = true;

                myView.printString("\n"); // Friendly linespacing.
            }  // end while loop
            return;
        } // end constructor

    } // class
} // namespace



