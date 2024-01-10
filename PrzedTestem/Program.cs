using Microsoft.VisualBasic;

namespace PrzedTestem
{
    internal class Program
    {
        public delegate bool Logic(bool a, bool b);
        static void Main(string[] args)
        {


        }

        internal class Timer
        {

            int _seconds;
            bool _isRunning;


            public Timer(int seconds)
            {
                _seconds = seconds;
                _isRunning = false;
            }
            int Seconds
            {
                get { return _seconds; }
                set
                {
                    if (value > 0)
                    {
                        _seconds = value;
                    }
                    else
                    {
                        Console.WriteLine("Wartość musi być dodatnia");
                    }
                }
            }
            bool IsRunning
            {
                get { return _isRunning; }
            }

            public delegate void TimerEventHandler(object sender, TimerEventArgs e);
            internal class TimerEventArgs : EventArgs
            {
                int CurrentSeconds { get; }
                public TimerEventArgs(int currentSeconds)
                {
                    CurrentSeconds = currentSeconds;
                }
                
            }

            public event TimerEventHandler TimerTick;
        public event TimerEventHandler TimerDone;

        public void Start()
        {
            if (!_isRunning)
            {
                _isRunning = true;

                while (_seconds > 0)
                {
                    Thread.Sleep(1000);

                    _seconds--;

                        
                }
            }
        }
    }



        /*public static void MainDoDelegatów()
        {
            bool x, y;
            x = GetIntFromUser("Podaj bool1");
            y = GetIntFromUser("Podaj bool2");

            Logic and = new Logic(And);
            Logic or = new Logic(Or);
            Logic xor = new Logic(Xor);
            Logic not = new Logic(Not);

            DisplayResult(and, x, y);
            DisplayResult(or, x, y);
            DisplayResult(xor, x, y);
            DisplayResult(not, x, y);
        }
        public static bool And(bool a, bool b)
        {
            if (a == true && b == true) return true;
            else return false;
        }
        public static bool Or(bool a, bool b)
        {
            if (a == false && b == false) return false;
            else return true;
        }
        public static bool Xor(bool a, bool b)
        {
            if ((a == false && b == true) || (b == false && a == true)) return true;
            else return false;
        }
        public static bool Not(bool a, bool b)
        {
            return !a;
        }
        public static void DisplayResult(Logic logic, bool a, bool b)
        {
            bool result;
            result = logic(a, b);
            Console.WriteLine($"Wynik {logic.Method.Name} z {a} i {b} to {result}");
        }
        public static bool GetIntFromUser(string prompt)
        {
            Console.Write(prompt);
            bool a;
            string? input = Console.ReadLine();
            bool isValid = bool.TryParse(input, out a);
            while (!isValid)
            {
                Console.Write("Nieprawidłowe dane. Podaj liczbe całkowitą nieujemną:");
                input = Console.ReadLine();
                isValid = bool.TryParse(input, out a);
            }
            return a;
        }*/
    }
    
}
