internal class t01
{
    private static void Main(string[] args)
    {
        Console.Write("Enter your favourite food: ");
        string food=Console.ReadLine();
        Console.Write("Enter tour favourite TV show: ");
        string show = Console.ReadLine();

        Console.WriteLine($"I like to eat {food} while watching {show}.");
    }
}