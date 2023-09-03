namespace FizzBuzz.App;

public static class ConsoleInteractor
{
    public static int GetRangeFromUser()
    {
        Console.Write("Please enter a number range: ");

        int range;

        while (!int.TryParse(Console.ReadLine(), out range))
        {
            Console.Write("Invalid input. Please enter a valid integer for the range: ");
        }
        
        return range;
    }
    
    public static void PrintResults(IEnumerable<string> results)
    {
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
        
        Console.WriteLine("Press any key to exit...");
    }
}