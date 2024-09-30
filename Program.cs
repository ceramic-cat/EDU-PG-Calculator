using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while keepRunning is true, the program loop will keep running.
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Welcome to the calculator.");

                float userFirstNumber;
                float userSecondNumber;
                string userOperator;
                // gets first number from user
                userFirstNumber = GetNumber();

                // gets second number from user
                userSecondNumber = GetNumber();

                // gets operator from user
                userOperator = GetOperator();

                // new instance of calculator with user inputs
                Calculator userCalculator = new Calculator(userFirstNumber, userSecondNumber, userOperator);

                // DoMath will do different things depending on what userOperator is.
                Console.WriteLine($"The answer to your query is {userCalculator.DoMath()}.");

                // A way out of the loop
                Console.WriteLine("If you want to terminate the application, write EXIT.");
                Console.WriteLine("To try again, write anything else.");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "exit")
                {
                    keepRunning = false;
                    Console.WriteLine("Good bye!");
                }
                Console.Clear();
            }

            // Method for ensuring number input. 
            float GetNumber()
            {
                float number = 0;
                bool input = false;
                // Will keep on asking the user for a number until it's recieved.
                do
                {
                    Console.WriteLine("Please input a number: ");

                    // tryParse will turn input into true when it recieves something it can turn into a float, which ends the loop.
                    input = float.TryParse(Console.ReadLine(), out number);

                }
                while (!input);

                return number;
            }

            // Method for getting a value contained in OperatorValues in the Calculator class.
            string GetOperator()
            {
                string userOperator;
                bool input = false;

                do
                {
                    Console.WriteLine("Please input a mathematical operator (+, -, * or /)");
                    userOperator = Console.ReadLine();
                    // when a string that is in OperatorValues is entered, input becomes true, which ends the loop.
                    input = Calculator.OperatorValues.Contains(userOperator);
                }
                while (!input);

                return userOperator;
            }
        }


        class Calculator
        {
            // everything is private set to protect the data
            public float FirstValue { get; private set; }
            public float SecondValue { get; private set; }
            public string Operator { get; private set; }

            // static list with accepted mathematical operators
            public static List<string> OperatorValues { get; private set; } = new List<string> { "+", "-", "*", "/" };

            // constructor
            public Calculator(float firstValue, float secondValue, string operatorValue)
            {
                FirstValue = firstValue;
                SecondValue = secondValue;
                Operator = operatorValue;
            }

            // method for doing calculations depending on what Operator the calculator-instance has.
            public float DoMath()
            {
                switch (this.Operator)
                {
                    case "+": return this.FirstValue + this.SecondValue;
                    case "-": return this.FirstValue - this.SecondValue;
                    case "*": return this.FirstValue * this.SecondValue;
                    case "/": return this.FirstValue / this.SecondValue;
                    default: return 0;
                }

            }

        }
    }

}
