namespace FizzBuzz.Domain;

public class Fizz : ITransformer
{
    public string Transform(int number) => number % 3 == 0 ? "Fizz" : "";
}