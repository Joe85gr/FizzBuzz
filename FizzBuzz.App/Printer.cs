using FizzBuzz.Domain;

namespace FizzBuzz.App;

public class Printer : IRunner
{
    private readonly ITransformationService _service;
    public Printer(ITransformationService service)
    {
        _service = service;
    }
    
    public void Run()
    {
        var range = ConsoleInteractor.GetRangeFromUser();
        
        var results = GetTransformationsResults(range);
        
        ConsoleInteractor.PrintResults(results);
    }
    
    private IEnumerable<string> GetTransformationsResults(int range)
    {
        for (var i = 1; i <= range; i++)
        {
            yield return _service.Transform(i);
        }
    }
}