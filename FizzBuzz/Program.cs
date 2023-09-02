using FizzBuzz;

var transformations = new ITransformer[]
{
    new Fizz(), 
    new Buzz()
};

const int range = 100;
var executor = new TransformationExecutor(transformations);

Printer.PrintNumberTransformations(range, executor);
