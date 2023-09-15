using System.Text;

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
        var result = new StringBuilder();
        
        foreach (var transformer in _transformers)
        {
            result.Append(transformer.Transform(number));
        }
        
        if (result.Length == 0)
        {
            result.Append(number);
        }

        return result.ToString();
    }
}