namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            // Lets make a calculator shall we

            // Uppgift bas: Gör mkt enkelt program och gör div git-grejer med det


            // Lets do a calculatoooor

            // Nästa uppgift: "Grafiskt interface"



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


            //public Calculator(string operatorValue)
            //{
                
            //}

            public Calculator( float firstValue, string operatorValue, float secondValue)
            {
                FirstValue = firstValue;
                SecondValue = secondValue;
                Operator = operatorValue;
            }

            public Calculator (float firstValue, float secondValue, string operatorValue)
            {
                FirstValue = firstValue;
                SecondValue = secondValue;
                Operator = operatorValue;

            }
            // Lista eller dictionary med olika operatorer

            public string[] operatorValues = { "+", "-", "*", "/", "Sqrt", "PowerTo" };

        }


    }




}
