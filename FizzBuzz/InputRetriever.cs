namespace FizzBuzz;

public static class InputRetriever
{
    public static int GetNumberRangeFromUser()
    {
        Console.Write("Please enter a number range: ");

        int range;

        while (!int.TryParse(Console.ReadLine(), out range))
        {
            Console.Write("Invalid input. Please enter a valid integer for the range: ");
        }
        
        return range;
    }
}