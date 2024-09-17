float kmH;
float mS;

Console.WriteLine("How fast are you going in km/h?");
kmH = float.Parse(Console.ReadLine());

mS = kmH * (5f/ 18f);
int roundedNr = (int) mS;

Console.WriteLine($"{kmH} km/h? That's {roundedNr} meters per second. Or {mS} if you want to be more precise.");