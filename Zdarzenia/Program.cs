namespace Zdarzenia
{
    public delegate void MessageHndler(string message);


    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher pub = new Publisher();
            Subscriber sub = new Subscriber();

            pub.MessageEvent += sub.OnMessageReceved;
            //pub.MessageEvent -= sub.OnMessageReceved;
            

            pub.SendMessage("Hello!");
            pub.SendMessage("Hello!!");
            pub.SendMessage("Hello!!!");
            pub.MessageEvent +=sub.OnMessageReceved;
            pub.SendMessage("Hello!!!!");
            pub.MessageEvent += sub.OnMessageReceved;
            pub.SendMessage("Hello!!!!!");
            pub.SendMessage("Hello!!!!!!");

        }
    }
}