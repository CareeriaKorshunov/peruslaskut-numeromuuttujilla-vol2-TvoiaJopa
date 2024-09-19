namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Koodi tähän
 double luku1, luku2, summa, osamäärä, erotus, tulo;

            Console.Write("Anna eka luku: ");
            luku1 = double.Parse(Console.ReadLine());
            Console.Write("Anna toka luku: ");
            luku2 = double.Parse(Console.ReadLine());

            summa = luku1 + luku2;
            osamäärä = luku1 / luku2;
            tulo = luku1 * luku2;
            erotus = luku1 - luku2;

            Console.WriteLine("\nLukujen summa: " + luku1 + " + " + luku2 + " = " + summa);
            Console.WriteLine("Lukujen              erotus: " + luku1 + " - " + luku2 + " = " + erotus);
            Console.WriteLine("Lukujen Tulo: " + luku1 + " * " + luku2 + " = " + tulo);
            Console.WriteLine("Lukujen Osamäärä: " + luku1 + " / " + luku2 + " = " + osamäärä);
        }

    }
}
