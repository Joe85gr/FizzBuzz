namespace FizzBuzz;

public class Printer
{
    private readonly ITransformationExecutor _executor;
    public Printer(ITransformationExecutor executor)
    {
        _executor = executor;
    }
    
    public void PrintNumberTransformations(int range)
    {
        for (var i = 1; i <= range; i++)
        {
            var result = _executor.Transform(i);
            Console.WriteLine(result);
        }
    }
}