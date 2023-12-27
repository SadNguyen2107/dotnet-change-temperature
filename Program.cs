namespace MyProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UInt16 choice = 0;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");

            // Get Choice Input
            askChoiceInput:
                Console.Write("Enter your choice: ");
                bool isValid = UInt16.TryParse(Console.ReadLine(), out choice);
                if (!isValid)
                {
                    Console.WriteLine("Invalid Input");
                    goto askChoiceInput;
                }

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Write("Enter fahrenheit: ");
                        double fahrenheit = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(fahrenheit));
                        break;
                    case 2:
                        Console.Write("Enter Celsius: ");
                        double celsius = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Celsius to Fahrenheit: " + CelsiusToFahrenheit(celsius));
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }


            } while (true);
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }
    }
}