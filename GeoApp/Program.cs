using Microsoft.Extensions.DependencyInjection;
using System;
using GeoAppLibrary;
using Microsoft.Extensions.Configuration;
using Microsoft.FeatureManagement;
using Microsoft.Extensions.DependencyInjection;


namespace GeoApp
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var featureManagement = new Dictionary<string, string>
            {
                { "FeatureManagement:Square", "true" },
                { "FeatureManagement:Rectangle", "false" },
                { "FeatureManagement:Triangle", "true" }
            };

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(featureManagement)
                .Build();

            var services = new ServiceCollection();
            services.AddFeatureManagement(configuration);
            var serviceProvider = services.BuildServiceProvider();

            var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

            if (await featureManager.IsEnabledAsync("Square"))
            {
                Console.WriteLine("Square feature is enabled.");
                AcceptSquareDimensions();
            }

            if (await featureManager.IsEnabledAsync("Rectangle"))
            {
                Console.WriteLine("Rectangle feature is enabled.");
                AcceptRectangleDimensions();
            }

            if (await featureManager.IsEnabledAsync("Triangle"))
            {
                Console.WriteLine("Triangle feature is enabled.");
                AcceptTriangleDimensions();
            }
        }

      static void AcceptSquareDimensions()
{
    Console.WriteLine("Please enter the side length of the square:");
    double sideLength = double.Parse(Console.ReadLine());
    var square = new Square(sideLength);
     double area = square.CalculateArea();
    double perimeter = square.CalculatePerimeter();

    Console.WriteLine($"Area of Square: {area}");
    Console.WriteLine($"Perimeter of Square: {perimeter}");
}


       static void AcceptRectangleDimensions()
{
    Console.WriteLine("Please enter the length of the rectangle:");
    double length = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the width of the rectangle:");
    double width = double.Parse(Console.ReadLine());
    var rectangle = new Rectangle(length, width);

    double area = rectangle.CalculateArea();
    double perimeter = rectangle.CalculatePerimeter();

    Console.WriteLine($"Area of Rectangle: {area}");
    Console.WriteLine($"Perimeter of Rectangle: {perimeter}");
}
    
      static void AcceptTriangleDimensions()
{
    Console.WriteLine("Please enter the length of side 1 of the triangle:");
    double side1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the length of side 2 of the triangle:");
    double side2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the length of side 3 of the triangle:");
    double side3 = double.Parse(Console.ReadLine());

    var triangle = new Triangle(side1, side2, side3);
    double area = triangle.CalculateArea();
    double perimeter = triangle.CalculatePerimeter();

    Console.WriteLine($"Area of Triangle: {area}");
    Console.WriteLine($"Perimeter of Triangle: {perimeter}");
}
    }
}
