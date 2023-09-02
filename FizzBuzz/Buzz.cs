namespace FizzBuzz;

public class Buzz : ITransformer
{
    public string Transform(int number) => number % 5 == 0 ? "Buzz" : "";
}