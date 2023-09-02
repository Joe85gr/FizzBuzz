namespace FizzBuzz;

public static class Printer
{
    public static void PrintNumberTransformations(int range, TransformationExecutor executor)
    {
        for (var i = 0; i <= range; i++)
        {
            var result = executor.Transform(i);
            Console.WriteLine(result);
        }
    }
}