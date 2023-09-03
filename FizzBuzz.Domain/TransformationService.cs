namespace FizzBuzz.Domain;

public class TransformationService : ITransformationService
{
    private readonly IEnumerable<ITransformer>  _transformers;

    public TransformationService(IEnumerable<ITransformer> transformers)
    {
        _transformers = transformers;
    }

    public string Transform(int number)
    {
        var result = string.Empty;
        
        foreach (var transformer in _transformers)
        {
            result += transformer.Transform(number);
        }

        return result == string.Empty ? number.ToString() : result;
    }
}