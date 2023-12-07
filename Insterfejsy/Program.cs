namespace Insterfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ksiazka> ks = new List<Ksiazka>();
            ks.Add(new Ksiazka("Hobbit", "Tolkien2", 1936, 20));
            ks.Add(new Ksiazka("Hobbit2", "Tolkien1", 1937, 30));
            ks.Add(new Ksiazka("Hobbit3", "Tolkien3", 1938, 10));
            ks.Sort();
            foreach (Ksiazka ks2 in ks)
            {
                Console.WriteLine(ks2);
            }
            Console.WriteLine();
            var sortedByYear = ks.OrderBy(b => b.RokWydania);
            foreach (Ksiazka ks2 in sortedByYear)
            {
                Console.WriteLine(ks2);
            }
            Console.WriteLine();
            var sortedByAuthor = ks.OrderByDescending(b => b.Autor);
            foreach (Ksiazka ks2 in sortedByAuthor)
            {
                Console.WriteLine(ks2);
            }
            Console.WriteLine();
            var sortedByPriceAndYear = ks.OrderByDescending(b => b.Cena).ThenBy(b => b.RokWydania);
            foreach (Ksiazka ks2 in sortedByPriceAndYear)
            {
                Console.WriteLine(ks2);
            }
        }
    }
}