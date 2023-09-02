using FizzBuzz;

var transformations = new ITransformer[]
{
    new Fizz(), 
    new Buzz()
};

var executor = new TransformationExecutor(transformations);
var printer = new Printer(executor);

Console.Write("Please enter the range: ");

int range;

while (!int.TryParse(Console.ReadLine(), out range))
{
    Console.Write("Invalid input. Please enter a valid integer for the range: ");
}

printer.PrintNumberTransformations(range);