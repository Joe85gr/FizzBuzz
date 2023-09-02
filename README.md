# FizzBuzz
A overengineered FizzBuzz implementation which doesn't violate SRP and OC principles

## Problem Description
_Write a program that prints the numbers from 1 to 100. But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”. For numbers which are multiples of both three and five print “FizzBuzz”._

## Expanding with new requirements
### Additional Hypothetical Scenario:
_A new requirement came in, and for multiples of seven we need to print "Pip"_

### Solution:
Create a new class, which implements ITransformer with the new transformation.
That's it. Now our code will be able to support the new requirements, without worrying to break the previous requirements:

```csharp
public class Buzz : ITransformer
{
    public string Transform(int number) => number % 7 == 0 ? "Pip" : "";
}
```

### Notes:
Yes, the order of the transformers is important. Having Buzz before Fizz, would break the tests.
However, in a real scenario, the TransformationExecutor would receive the ITransformer through dependency injection, so the developers would be in control of the order and ensure it is correct. All the user would do is pass a range of numbers and wait for the result.