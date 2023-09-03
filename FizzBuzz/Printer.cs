using FizzBuzz.Domain;

namespace FizzBuzz;

public class Printer : IRunner
{
    private readonly ITransformationService _service;
    public Printer(ITransformationService service)
    {
        _service = service;
    }
    
    public void Run()
    {
        var range = InputRetriever.GetNumberRangeFromUser();
        var results = GetTransformations(range);
        
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
        
        Console.WriteLine("Press any key to exit...");
    }
    
    private IEnumerable<string> GetTransformations(int range)
    {
        for (var i = 1; i <= range; i++)
        {
            yield return _service.Transform(i);
        }
    }
}