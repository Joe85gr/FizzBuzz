# FizzBuzz
A overengineered FizzBuzz implementation which doesn't violate SRP and OC principles

## Problem Description
_Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”._

## Expanding with new requirements
### Additional Hypothetical Scenario:
_A new requirement came in, and for multiples of seven we need to print "Pip"_

### Solution:
Create a new class, which implements ITransformer with the new transformation:
```csharp
public class Pip : ITransformer
{
    public string Transform(int number) => number % 7 == 0 ? "Pip" : "";
}
```

Register the new transformer in program.cs:

```csharp
using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<ITransformer, Fizz>();
        services.AddTransient<ITransformer, Buzz>();
        services.AddTransient<ITransformer, Pip>(); //  <-- 
        services.AddTransient<ITransformationService, TransformationService>();   
        services.AddTransient<IPrinter, Printer>();   
    })
    .Build();
```

That's it. Now our code will be able to support the new requirements, without worrying to break the previous requirements:


### Notes:
The order of the transformers services registration is important. Registering Buzz before Fizz, would break the tests.
Thankfully, the order is controlled in the DI by the developer, and not the user :D