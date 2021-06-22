using System;
using FluentAssertions;

namespace app_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class exampleClass {
    public void additionMethod() {
        var first = 3;
        var second = 7;
        var result = first + second;

        result.Should().Be(10);
        }
    }
}
