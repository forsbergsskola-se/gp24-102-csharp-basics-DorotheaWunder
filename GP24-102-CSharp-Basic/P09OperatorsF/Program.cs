float circleRadius;
float circleArea;
double pi;

Console.WriteLine($"The circle radius is:");
circleRadius = float.Parse(Console.ReadLine());

pi = Math.PI;
circleArea = (float)pi * (float)Math.Pow(circleRadius, 2);

Console.WriteLine($"A circle with a radius of {circleRadius} has an area of {circleArea}:");