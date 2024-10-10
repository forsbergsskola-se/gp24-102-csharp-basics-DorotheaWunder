float valueWeight;
float valueHeight;
float valueBmi;

Console.WriteLine("Enter your weight in kg:");
valueWeight = float.Parse(Console.ReadLine());

Console.WriteLine("Enter your height in m:");
valueHeight = float.Parse(Console.ReadLine());

valueBmi =  valueWeight / (float)Math.Pow(valueHeight, 2);

Console.WriteLine($"A person with a weight of {valueWeight} and a height of {valueHeight} has a BMI of {valueBmi}");