namespace Demo13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardinaliteHorizontal bruxellesLatitude = CardinaliteHorizontal.Est;
            CardinaliteVertical bruxellesLongitude = CardinaliteVertical.Nord;

            Cardinalite directionVent = Cardinalite.Ouest;

            Console.Write("Le vent soufle dans la direction : ");
            if (directionVent.HasFlag(Cardinalite.Nord))
            {
                Console.Write("Nord ");
            }
            else if (directionVent.HasFlag(Cardinalite.Sud))
            {
                Console.Write("Sud ");
            }
            if (directionVent.HasFlag(Cardinalite.Est))
            {
                Console.WriteLine("Est");
            }
            else if (directionVent.HasFlag(Cardinalite.Ouest))
            {
                Console.WriteLine("Ouest");
            }
        }
    }
}
