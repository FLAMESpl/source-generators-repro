using Microsoft.CodeAnalysis;

namespace SourceGenerators
{
    [Generator]
    public class MyGenerator : ISourceGenerator
    {
        private readonly string source = @"
using System;
namespace SourceGeneratorsRepro
{
    public static class HelloWorld
    {
        public static void SayHello() 
        {
            Console.WriteLine(""Hello from generated code!"");
            Console.WriteLine(""The following syntax trees existed in the compilation that created this program:"");
        }
    }
}
";

        public void Execute(GeneratorExecutionContext context)
        {
            context.AddSource("HelloWorld", source);
        }

        public void Initialize(GeneratorInitializationContext context)
        {
        }
    }
}
