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
            Console.WriteLine("Hello, World!");



            // Lets make a calculator shall we

            // Uppgift bas: Gör mkt enkelt program och gör div git-grejer med det


            // Lets do a calculator
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Welcome to the calculator.");

                float userFirstNumber;
                float userSecondNumber;
                string userOperator;

                while (keepRunning)
                {

                    userFirstNumber = GetNumber();
                    userSecondNumber = GetNumber();
                    userOperator = GetOperator();

                    Calculator userCalculator = new Calculator(userFirstNumber, userSecondNumber, userOperator);

                    Console.WriteLine($"The answer to your query is {userCalculator.DoMath()}.");

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


                float GetNumber()
                {
                    float number = 0;
                    bool input = false;

                    do
                    {
                        Console.WriteLine("Please input a number: ");
                        input = float.TryParse(Console.ReadLine(), out number);

                    }
                    while (!input);

                    return number;
                }


                string GetOperator()
                {
                    string userOperator;
                    bool input = false;

                    do
                    {
                        Console.WriteLine("Please input a mathematical operator (+, -, * or /)");
                        userOperator = Console.ReadLine();
                        input = Calculator.OperatorValues.Contains(userOperator);
                    }
                    while (!input);

                    return userOperator;
                }
            }


        }


        class Calculator
        {

            public float FirstValue { get; private set; }
            public float SecondValue { get; private set; }
            public string Operator { get; private set; }

            public static List<string> OperatorValues { get; private set; } = new List<string> { "+", "-", "*", "/" };


            public Calculator(float firstValue, float secondValue, string operatorValue)
            {
                FirstValue = firstValue;
                SecondValue = secondValue;
                Operator = operatorValue;
            }

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
