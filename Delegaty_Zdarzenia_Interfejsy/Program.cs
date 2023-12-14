using System;
using System.Collections.Generic;
namespace _7_2_interfejsy_zadanie_2
{
    public interface IRandomList
    {
        int Count { get; }
        void Display();
        List<int> DivisibleBy3Or5();
        List<int> Odd();
        List<int> Ascending();
        List<int> Descending();
        public event EmptyListHandler EmptyList;
    }

    delegate List<int> ListOperation(IRandomList list);
    public delegate void EmptyListHandler();

    class RandomList : IRandomList 
    {
        public event EmptyListHandler? EmptyList ;
        private List<int> list;
        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public RandomList(int length, int min, int max)
        {
            list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                list.Add(rnd.Next(min, max + 1));
            }

            if (list.Count == 0)
            {
                //EmptyList?.Invoke();

            }
        }
        public void Display()
        {
            if (list.Count == 0)
            {
                EmptyList?.Invoke();
                return;
            }
            foreach (int x in list)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }

        public List<int> DivisibleBy3Or5()
        {
            List<int> result = new List<int>();
            
            foreach (int x in list)
            {
                if(x%3==0 || x % 5 == 0)
                {
                    result.Add(x);
                }
            }
            return result;
        }

        public List<int> Odd()
        {
            List<int> result = new List<int>();
            foreach (int x in list)
            {
                if (x%2==1)
                {
                    result.Add(x);
                }
            }
            return result;
        }

        public List<int> Ascending()
        {
            List<int> result = new List<int>();

            foreach (int x in list)
            {
                result.Add(x);
            }
            result.Sort();
            return result;
        }

        public List<int> Descending()
        {
            List<int> result = new List<int>();
            
            foreach (int x in list)
            {
                result.Add(x);
            }
            
            result.Sort();
            result.Reverse();
            
            return result;
        }
    }
    internal class Program
    {
        static void PerformOperation(IRandomList list, ListOperation operation, string message) 
        {
            List<int> result = operation(list as RandomList);

            Console.WriteLine(message);
            foreach(int x in result)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
        static void ShowMessage()
        {
            Console.WriteLine("Lista jest pusta!");
        }
        static void ShowMenu()
        {
            Console.WriteLine("Co chcesz zrobić z listą?");
            Console.WriteLine("1 - Wyświetlić listę liczb podzielnych przez 3 lub 5");
            Console.WriteLine("2 - Wyświetlić listę liczb nieparzystch");
            Console.WriteLine("3 - Wyświetlić listę liczb posortowanych niemalejąco");
            Console.WriteLine("4 - Wyświetlić listę liczb posortowanych nierosnąco");
            Console.WriteLine("5 - Wyjście z programu");

        }
        static void Main(string[] args)
        {
            IRandomList randomList = new RandomList(20, 1, 100);

            randomList.EmptyList += ShowMessage;

            Console.WriteLine("Lista liczb losowych");
            randomList.Display();
            
            int choice = 0 ;
            
            do
            {
                ShowMenu();

                Console.WriteLine("Podaj swój wybór:");
                string? input = Console.ReadLine();

                if (input != "")
                {
                    bool success =  int.TryParse(input, out choice);
                    if (success)
                    {
                        switch (choice)
                        {
                            case 1 :
                                PerformOperation(randomList, list => list.DivisibleBy3Or5(), "Lista liczb podzielonych przez 3 lub 5");
                                break;
                            case 2:
                                PerformOperation(randomList, list => list.Odd(), "Lista liczb nieparzystych");
                                break;
                            case 3:
                                PerformOperation(randomList, list => list.Ascending(), "Lista liczb posortowanych niemalejąco");
                                break;
                            case 4:
                                PerformOperation(randomList, list => list.Descending(), "Lista liczb posortowanych nierosnąco");
                                break;
                            case 5:
                                Console.WriteLine("Dziękuje za skorzystanie z programu. Do zobaczenia");
                                break;
                            default: 
                                Console.WriteLine("Niepoprawny wybór. Spróbuj ponownie");
                                break;

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nie podano żadnego wyboru. Spróbuj ponownie");
                }
            }
            while (choice != 5);
            
        }
    }
}