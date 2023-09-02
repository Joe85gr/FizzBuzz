namespace FizzBuzz;

public class TransformationExecutor : ITransformationExecutor
{
    private readonly ITransformer[] _transformers;

    public TransformationExecutor(ITransformer[] transformers)
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