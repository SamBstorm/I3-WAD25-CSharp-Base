namespace Exo16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius bruxelles;
            bruxelles.temperature = 8;
            Console.WriteLine($"Ici à Bruxelles, il fait actuellement {bruxelles.temperature} °C. En Fahrenheit, il ferait {bruxelles.Convert().temperature} °F.");
            Fahrenheit newyork;
            newyork.temperature = 10;
            Console.WriteLine($"De l'autre côté du globe, à New-york, on imagine qu'il fait actuellement {newyork.temperature} °F. Cela ferait en Celsius : {newyork.Convert().temperature} °C.");
        }
    }
}
