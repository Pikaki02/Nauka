using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    internal class Subscriber
    {
        public void OnMessageReceved(string message)
        {
            Console.WriteLine("Otrzymałem wiadomość: {0}", message);
        }
        public void OnCounterReached(int x)
        {
            Console.WriteLine("Osiągnięto limit: {0}",x);
        }
    }
}
