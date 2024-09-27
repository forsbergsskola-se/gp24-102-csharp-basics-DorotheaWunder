float sideA;
float sideB;
float sideC;

Console.WriteLine("Length of side A:");
sideA = float.Parse(Console.ReadLine());

Console.WriteLine("Length of side B:");
sideB = float.Parse(Console.ReadLine());

float sideAsquared = (float)Math.Pow(sideA, 2);
float sideBsquared = (float)Math.Pow(sideB, 2);
sideC = (float)Math.Sqrt(sideAsquared + sideBsquared);

Console.WriteLine($"The remaining side C has a length of {sideC}");