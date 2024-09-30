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
                Console.WriteLine("\tWelcome to the calculator.");
                Console.WriteLine("\n\tPlease enter a number:");

                float userFirstNumber = float.Parse(Console.ReadLine());


                Console.WriteLine("\n\tPlease enter a number:");

                float userSecondNumber = float.Parse(Console.ReadLine());

                Console.WriteLine("\n\t What operator would you like to use?");
                string userOperator = Console.ReadLine();

                // Make a calculator
                Calculator userCalculator = new Calculator(userSecondNumber, userFirstNumber, userOperator);



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

            public Calculator(float firstValue, string operatorValue, float secondValue)
            {
                FirstValue = firstValue;
                SecondValue = secondValue;
                Operator = operatorValue;
            }

            public Calculator(float firstValue, float secondValue, string operatorValue)
            {
                FirstValue = firstValue;
                SecondValue = secondValue;
                Operator = operatorValue;
            }

            public static float DoMath(Calculator calculator)
            {
                string hello = calculator.Operator;
                if (OperatorValues.Contains(hello))
                {
                    switch(calculator.Operator)
                        {
                        case "+": return calculator.FirstValue + calculator.SecondValue;
                        case "-": return calculator.FirstValue - calculator.SecondValue;
                        case "*": return calculator.FirstValue * calculator.SecondValue;
                        case "/": return calculator.FirstValue / calculator.SecondValue;
                            default: return 0;
                    }

                }
                else
                { return 0; }
            }

        }


    }




}
