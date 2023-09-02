using FizzBuzz;

var transformations = new ITransformer[]
{
    new Fizz(), 
    new Buzz()
};

Console.Write("Please enter the range: ");

int range;

while (!int.TryParse(Console.ReadLine(), out range))
{
    Console.Write("Invalid input. Please enter a valid integer for the range: ");
}
var executor = new TransformationExecutor(transformations);

Printer.PrintNumberTransformations(range, executor);