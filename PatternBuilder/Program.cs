using System;

namespace PatternBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();

            director.Builder = builder;
            Console.WriteLine("MVP");
            director.buildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Full");
            director.buildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());


            // without Director class
            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.ReadKey();
        }
    }
}
