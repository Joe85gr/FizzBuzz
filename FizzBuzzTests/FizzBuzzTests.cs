using FizzBuzz.Domain;
using FluentAssertions;

namespace FizzBuzzTests;

public class TransformationServiceTests
{
    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void ReturnsFizz_WhenNumberIsDivisibleBy3(int number)
    {
        // Arrange
        const string expectedResult = "Fizz";
    
        var transformers = new ITransformer[]
        {
            new Fizz()
        };
        
        var sut = new TransformationService(transformers);
        
        // Act
        var result = sut.Transform(number);
    
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(20)]
    public void ReturnsBuzz_WhenNumberIsDivisibleBy5(int number)
    {
        // Arrange
        const string expectedResult = "Buzz";
    
        var transformers = new ITransformer[]
        {
            new Buzz()
        };
        
        var sut = new TransformationService(transformers);
        
        // Act
        var result = sut.Transform(number);
    
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    [InlineData(45)]
    public void ReturnsFizzBuzz_WhenNumberIsDivisibleBy5_and_3(int number)
    {
        // Arrange
        const string expectedResult = "FizzBuzz";
    
        var transformers = new ITransformer[]
        {
            new Fizz(),
            new Buzz()
        };
        
        var sut = new TransformationService(transformers);
        
        // Act
        var result = sut.Transform(number);
    
        // Assert
        result.Should().Be(expectedResult);
    }
    
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(4, "4")]
    [InlineData(8, "8")]
    public void ReturnsNumber_WhenNumberIsNotDivisibleByAnyTransformer(int number, string expectedResult)
    {
        // Arrange
        var transformers = new ITransformer[]
        {
            new Fizz(),
            new Buzz()
        };
        
        var sut = new TransformationService(transformers);
        
        // Act
        var result = sut.Transform(number);
    
        // Assert
        result.Should().Be(expectedResult);
    }
}
