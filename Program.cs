using System.Net.Http.Headers;

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
                Console.WriteLine("Please enter a number:");

                // Getting first value
                if (float.TryParse(Console.ReadLine(), out float userFirstNumber))
                {
                    Console.WriteLine("Please enter a number: ");

                    if (float.TryParse(Console.ReadLine(), out float userSecondNumber))
                    {
                        Console.WriteLine("What operator would you like to use?");
                        string userOperator = Console.ReadLine();

                        // Control the input for choice of operator.
                        if (Calculator.OperatorValues.Contains(userOperator))
                        {
                            // Make a calculator
                            Calculator userCalculator = new Calculator(userSecondNumber, userFirstNumber, userOperator);

                            Console.WriteLine($"The answer to your query is {userCalculator.DoMath(userCalculator)}");
                        }
                        else
                        {
                            Console.WriteLine("Please only use valid operators: +, -, * or /.");
                        }

                    }
                    else Console.WriteLine("Please only use numbers.");

                }
                else
                {
                    Console.WriteLine("Please only use numbers.");
                }
                Console.WriteLine("If you want to terminate the application, write exit.");
                Console.WriteLine("To try again, write anything else.");
                string userInput = Console.ReadLine().ToLower();

                if (userInput == "exit")
                {
                    keepRunning = false;
                    Console.WriteLine("Good bye!");
                }
                Console.Clear();

            }


            // TODO
            // Klass som gör matematik

            // Om jag orkar, gör med valbar RPN/normal style ;)

            // Möjliga operationer:
            // +, -, *, /, %, 

            // Metod för inmatning av siffror (floats?) med kontroll av att det är faktiska siffror
            // Metod för inmatning av operationer, valbara med char? Eller ur meny?


        }


        class Calculator
        {
            //private float _firstValue;
            //private float _secondValue;
            //private char _operator;

            public float FirstValue { get; private set; }
            public float SecondValue { get; private set; }
            public string Operator { get; private set; }

            public static List<string> OperatorValues { get; private set; } = new List<string> { "+", "-", "*", "/" };
            //public Calculator(string operatorValue)
            //{

            //}

            //public Calculator(float firstValue, string operatorValue, float secondValue)
            //{
            //    FirstValue = firstValue;
            //    SecondValue = secondValue;
            //    Operator = operatorValue;
            //}

            public Calculator(float firstValue, float secondValue, string operatorValue)
            {
                FirstValue = firstValue;
                SecondValue = secondValue;
                Operator = operatorValue;
            }

            public float DoMath(Calculator calculator)
            {
                string hello = calculator.Operator;
                if (OperatorValues.Contains(hello))
                {
                    switch (calculator.Operator)
                    {
                        case "+": return calculator.FirstValue + calculator.SecondValue;
                        case "-": return calculator.FirstValue - calculator.SecondValue;
                        case "*": return calculator.FirstValue * calculator.SecondValue;
                        case "/": return calculator.SecondValue / calculator.FirstValue;
                        default: return 0;
                    }

                }
                else
                { return 0; }
            }

        }


    }




}
