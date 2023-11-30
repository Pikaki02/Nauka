namespace Delegaty
{
    public delegate int Operation(int x, int y);
    internal class Program
    {
        public static int Add(int x, int y) 
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int x, int y)
        {
            return x / y;
        }
        public static void DisplayResult(Operation op, int x, int y)
        {
            int result;

            if (op.Method.Name == "Divide" && y == 0)
            {
                Console.WriteLine("\nBłąd: Dzielenie przez 0");
                result = 0;
            }
            else
            {
                result = op(x, y);
                Console.WriteLine("Wynik operacji {0} na liczbach {1} i {2} to {3}",op.Method.Name, x, y, result);
            }
        }
        public static int GetIntFromUser(string prompt)
        {
            Console.Write(prompt);
            int number;
            string? input = Console.ReadLine();
            bool isValid = int.TryParse(input, out number) && number > 0;
            while (!isValid) 
            {
                Console.Write("Nieprawidłowe dane. Podaj liczbe całkowitą nieujemną:");
                input = Console.ReadLine();
                isValid = int.TryParse(input, out number) && number > 0;
            }
            return number;
        }
        static void Main(string[] args)
        {
            int a = GetIntFromUser("Podaj pierwszą liczbe:");
            int b = GetIntFromUser("Podaj drugą liczbe:");

            Operation adding = new Operation(Add);
            Operation subtracting = new Operation(Subtract);
            Operation multiplying = new Operation(Multiply);
            Operation dividing = new Operation(Divide);

            DisplayResult(adding, a, b);
            DisplayResult(subtracting, a, b);
            DisplayResult(multiplying, a, b);
            DisplayResult(dividing, a, b);

        }
    }
}