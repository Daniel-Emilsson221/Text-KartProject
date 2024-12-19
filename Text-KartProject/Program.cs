using System.Dynamic;

class Program
{
    public static void Main(string[] args)
    {
        Vehicle vehicle1 = new Vehicle(30, 24, 18);
        Vehicle vehicle2 = new Vehicle(26, 30, 15);
        Console.WriteLine("Vehicle1 och Vehicle2 racear");
        Console.ReadLine();

        if (vehicle1.GetRating() > vehicle2.GetRating())
        {
            Console.WriteLine("Bil 1 är bäst");
        }
        int EngineRating =-1;
        while (EngineRating == -1)
        {

            Console.WriteLine("Hur bra vill du att din egna bil ska vara?");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out EngineRating))
            {
                Console.WriteLine("Try again, number need to be 1-30");
                EngineRating = -1;
            }
        }

        EngineRating = -1;
    }
}